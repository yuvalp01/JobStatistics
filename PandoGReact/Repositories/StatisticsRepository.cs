using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Repositories
{
    public class StatisticsRepository:Repository
    {
        public StatisticsRepository(JobContext context) : base(context)
        {
        }


        /// <summary>
        /// This function return the data in a G charts array format
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Create DataPoint list based on the statistics tables
        /// </summary>
        /// <returns></returns>
        private IEnumerable<DataPoint> GetDataPoints()
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
