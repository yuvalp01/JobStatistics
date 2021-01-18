using PandoGReact.Logic;
using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Repositories
{
    public class RawDataRepository: Repository
    {

        public RawDataRepository(JobContext context) : base(context)
        {
        }



        public override IEnumerable<IEnumerable<object>> GetChartDataObject()
        {
            Statistics statistics = new Statistics();
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
                List<object> row = new List<object>();
                //Date
                row.Add(date.ToString("MMM d"));

                //Views 
                int viewCount = 0;
                views.TryGetValue(date, out viewCount);
                row.Add(viewCount);

                //Predictions
                int predCount = 0;
                predictions.TryGetValue(date, out predCount);
                row.Add(predCount);
                data.Add(row);

                row.Add(activeJobs[date]);

                //List<object> row = new List<object>
                //{
                //    date.ToString("MMM d"),
                //    views[date],
                //    predictions[date],
                //    activeJobs[date]
                //};
            }
            return data;
        }
        //public override IEnumerable<IEnumerable<object>> GetChartDataObject()
        //{
        //    List<object> title = GetTitles();
        //    IEnumerable<DataPoint> dataPoints = GetDataPoints();

        //    List<List<object>> data = new List<List<object>>();
        //    data.Add(title);
        //    foreach (var dataPoint in dataPoints)
        //    {
        //        List<object> row = new List<object> {
        //            dataPoint.Date.ToString("MMM d"),
        //            dataPoint.JobViews,
        //            dataPoint.ViewsPrediction,
        //            dataPoint.ActiveJobs
        //       };
        //        data.Add(row);
        //    }
        //    return data;
        //}


        //public IEnumerable<DataPoint> GetDataPoints()
        //{


        //    var dataPoints = from jobs in _context.JobsStats
        //                     join views in _context.ViewStats on jobs.Date equals views.Date
        //                     join pred in _context.PredictionStats on views.Date equals pred.Date
        //                     select new DataPoint
        //                     {
        //                         Date = jobs.Date,
        //                         ActiveJobs = jobs.Count,
        //                         JobViews = views.Count,
        //                         ViewsPrediction = pred.Count
        //                     };


        //    return dataPoints;

        //}
    }
}
