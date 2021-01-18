using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PandoGReact.Logic;
using PandoGReact.Models;
using PandoGReact.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobDataController : ControllerBase
    {
        private readonly JobContext _context;


        private readonly ILogger<JobDataController> _logger;

        public JobDataController(JobContext context, ILogger<JobDataController> logger)
        {
            _logger = logger;
            _context = context;
        }



        [HttpGet("chartData")]
        public IEnumerable<IEnumerable<object>> GetChartData()
        {
            List<object> title = GetTitles();
            IEnumerable<DataPoint> dataPoints = GetDataPoints();

            List<List<object>> data = new List<List<object>>();
            data.Add(title);
            foreach (var dataPoint in dataPoints)
            {
                List<object> row = new List<object> {
                 dataPoint.Date.ToString("MMM d"),dataPoint.JobViews,dataPoint.ViewsPrediction, dataPoint.ActiveJobs
               };
                data.Add(row);
            }
            return data;
        }

        private List<object> GetTitles()
        {
            return new List<object> { "Date", "Job views", "Predicted jobs views", "Active jobs" };
        }

        private List<List<object>>  GetDataPoints_new()
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



        private List<JobLine> CreateFakeJobLines()
        {

            List<JobLine> lines = new List<JobLine>();
            lines.Add(new JobLine { Id = 1, DateOpen = new DateTime(1, 5, 2020), DateClose = new DateTime(3, 5, 2020) });
            lines.Add(new JobLine { Id = 2, DateOpen = new DateTime(1, 5, 2020), DateClose = new DateTime(4, 5, 2020) });
            lines.Add(new JobLine { Id = 3, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 4, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 5, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 6, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 7, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 8, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 9, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            lines.Add(new JobLine { Id = 10, DateOpen = new DateTime(1, 5, 2020), DateClose = null });
            return lines;

        }

    }

}





            //var prediction = _context.jobViewPredictions
            //    .Select(a => new KeyValuePair{a.Date, a.Count })
            //    .ToDictionary(x => x.Date);
            //.Select(a=> new { a.Key, a.Count })
            //.AsEnumerable()
            //.ToDictionary(kvp=>kvp.Date,)

            //            var prediction = db
            //.Table
            //.Select(p => new { p.Key, p.Value })
            //.AsEnumerable()
            //.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
            ;


//var views = _context.Views_
//    .GroupBy(a => a.Date)
//    .Select(g=>new JobView { Date = g.Key, Count = g.Count()})
//    .ToList();
//List<DataPoint> dataPoints = new List<DataPoint>();  
