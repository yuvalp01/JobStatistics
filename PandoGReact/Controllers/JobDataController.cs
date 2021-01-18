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
       // private readonly StatisticsRepository _repo_stats;
        private readonly Repository _repo;

        public JobDataController(JobContext context, Repository repo, ILogger<JobDataController> logger)
        {
            _logger = logger;
             _repo = repo;
            //_repo_stats = new StatisticsRepository(context);
        }



        [HttpGet("chartData")]
        public IEnumerable<IEnumerable<object>> GetChartData()
        {

            var dataObject = _repo.GetChartDataObject();
            return dataObject;
        }

    }

}


