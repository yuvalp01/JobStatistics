using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}


        public IEnumerable<IEnumerable<object>> GetChartData_()
        {

            List<List<object>> data = new List<List<object>>();
            data.Add(new List<object> { "Date", "Job views", "Predicted jobs views", "Active jobs" });
            data.Add(new List<object> { new DateTime(2020, 05, 1).ToString("MMM d"), 50, 60, 20 });
            data.Add(new List<object> { new DateTime(2020, 05, 2).ToString("MMM d"), 70, 60, 25 });
            data.Add(new List<object> { new DateTime(2020, 05, 3).ToString("MMM d"), 100, 80, 30 });
            data.Add(new List<object> { new DateTime(2020, 05, 4).ToString("MMM d"), 150, 160, 33 });
            data.Add(new List<object> { new DateTime(2020, 05, 5).ToString("MMM d"), 550, 560, 30 });
            data.Add(new List<object> { new DateTime(2020, 05, 6).ToString("MMM d"), 300, 360, 50 });
            data.Add(new List<object> { new DateTime(2020, 05, 7).ToString("MMM d"), 450, 330, 70 });
            data.Add(new List<object> { new DateTime(2020, 05, 8).ToString("MMM d"), 700, 860, 80 });
            data.Add(new List<object> { new DateTime(2020, 05, 9).ToString("MMM d"), 805, 760, 75 });
            data.Add(new List<object> { new DateTime(2020, 05, 10).ToString("MMM d"), 1100, 1160, 90 });
            data.Add(new List<object> { new DateTime(2020, 05, 11).ToString("MMM d"), 1300, 1260, 92 });
            data.Add(new List<object> { new DateTime(2020, 05, 12).ToString("MMM d"), 1450, 1360, 99 });

            return data;
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


            //List<List<object>> data_ = new List<List<object>>();
            //data.Add(new List<object> { "Date", "Job views", "Predicted jobs views", "Active jobs" });
            //data.Add(new List<object> { new DateTime(2020, 05, 1).ToString("MMM d"), 50, 60, 20 });
            //data.Add(new List<object> { new DateTime(2020, 05, 2).ToString("MMM d"), 70, 60, 25 });
            //data.Add(new List<object> { new DateTime(2020, 05, 3).ToString("MMM d"), 100, 80, 30 });
            //data.Add(new List<object> { new DateTime(2020, 05, 4).ToString("MMM d"), 150, 160, 33 });
            //data.Add(new List<object> { new DateTime(2020, 05, 5).ToString("MMM d"), 550, 560, 30 });
            //data.Add(new List<object> { new DateTime(2020, 05, 6).ToString("MMM d"), 300, 360, 50 });
            //data.Add(new List<object> { new DateTime(2020, 05, 7).ToString("MMM d"), 450, 330, 70 });
            //data.Add(new List<object> { new DateTime(2020, 05, 8).ToString("MMM d"), 700, 860, 80 });
            //data.Add(new List<object> { new DateTime(2020, 05, 9).ToString("MMM d"), 805, 760, 75 });
            //data.Add(new List<object> { new DateTime(2020, 05, 10).ToString("MMM d"), 1100, 1160, 90 });
            //data.Add(new List<object> { new DateTime(2020, 05, 11).ToString("MMM d"), 1300, 1260, 92 });
            //data.Add(new List<object> { new DateTime(2020, 05, 12).ToString("MMM d"), 1450, 1360, 99 });

            return data;
        }

        private List<object> GetTitles()
        {
            return new List<object> { "Date", "Job views", "Predicted jobs views", "Active jobs" };
        }

        private List<DataPoint> GetDataPoints_()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            dataPoints.Add(new DataPoint { Date = new DateTime(2020, 05, 1), JobViews = 50, ViewsPrediction = 60, ActiveJobs = 20 });
            dataPoints.Add(new DataPoint { Date = new DateTime(2020, 05, 2), JobViews = 70, ViewsPrediction = 60, ActiveJobs = 25 });
            dataPoints.Add(new DataPoint { Date = new DateTime(2020, 05, 3), JobViews = 100, ViewsPrediction = 80, ActiveJobs = 30 });
            return dataPoints;
        }
        private IEnumerable<DataPoint> GetDataPoints()
        {

            var jobss = _context.Jobs.Find(1);
            var viewss = _context.JobViews.ToList();
            var predss= _context.jobViewPredictions.ToList();


            var dataPoints = from jobs in _context.Jobs
                             join views in _context.JobViews on jobs.Date equals views.Date
                             join pred in _context.jobViewPredictions on views.Date equals pred.Date
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

