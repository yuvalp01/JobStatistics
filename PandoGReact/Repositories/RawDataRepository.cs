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


        /// <summary>
        /// This function return the data in a G charts array format
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Turn raw data into statistics
        /// </summary>
        /// <param name="activeJobs"></param>
        /// <param name="views"></param>
        /// <param name="predictions"></param>
        /// <returns></returns>
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

            }
            return data;
        }

    }
}
