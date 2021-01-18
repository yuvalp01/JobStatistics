using PandoGReact.Logic;
using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Repositories
{
    public class LineRepository: Repository
    {

        public LineRepository(JobContext context) : base(context)
        {
        }



        private IEnumerable<IEnumerable<object>> GetDataPoints_new()
        {
            Statistics statistics = new Statistics();
            //  var list = Mocks.CreateFakeJobLines();
            var jobLines = _context.JobLines.ToList();
            Dictionary<DateTime, int> activeJobs = statistics.CalcStats(jobLines);
            Dictionary<DateTime, int> prediction = _context
                .PredictionStats
                .ToDictionary(p => p.Date, p => p.Count);

            var views = _context.ViewLines
                .GroupBy(a => a.Date)
                .Select(g => new ViewStat { Date = g.Key, Count = g.Count() })
                .ToDictionary(v => v.Date, v => v.Count);
            var dataObject = GenerateDataObject(activeJobs, views, prediction);
            return dataObject;
        }



        private List<List<object>> GenerateDataObject(
    Dictionary<DateTime, int> activeJobs,
    Dictionary<DateTime, int> views,
    Dictionary<DateTime, int> predictions)
        {
            List<object> title = GetTitles();
            List<List<object>> data = new List<List<object>>();
            data.Add(title);

            foreach (var date in activeJobs.Keys)
            {
                List<object> row_ = new List<object>
                {
                    date.ToString("MMM d"),
                    views[date],
                    predictions[date],
                    activeJobs[date]
                };
                data.Add(row_);
            }
            return data;
        }
        public override IEnumerable<IEnumerable<object>> GetChartDataObject()
        {
            List<object> title = GetTitles();
            IEnumerable<DataPoint> dataPoints = GetDataPoints();

            List<List<object>> data = new List<List<object>>();
            data.Add(title);
            foreach (var dataPoint in dataPoints)
            {
                List<object> row = new List<object> {
                    dataPoint.Date.ToString("MMM d"),
                    dataPoint.JobViews,
                    dataPoint.ViewsPrediction,
                    dataPoint.ActiveJobs
               };
                data.Add(row);
            }
            return data;
        }


        public IEnumerable<DataPoint> GetDataPoints()
        {


            var dataPoints = from jobs in _context.JobsStats
                             join views in _context.ViewStats on jobs.Date equals views.Date
                             join pred in _context.PredictionStats on views.Date equals pred.Date
                             select new DataPoint
                             {
                                 Date = jobs.Date,
                                 ActiveJobs = jobs.Count,
                                 JobViews = views.Count,
                                 ViewsPrediction = pred.Count
                             };


            return dataPoints;

        }
    }
}
