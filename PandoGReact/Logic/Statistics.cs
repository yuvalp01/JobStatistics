using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Logic
{
    public class Statistics
    {


        /// <summary>
        /// Take jobs raw data from db and calculate the active jobs per day
        /// </summary>
        /// <param name="jobLines"></param>
        /// <returns></returns>
        public Dictionary<DateTime, int> CalcStats(List<JobLine> jobLines)
        {
            var dates = jobLines.Select(a => a.DateOpen).Distinct();
            Dictionary<DateTime, int> jobsStats = new Dictionary<DateTime, int>();
            foreach (var currentDate in dates)
            {
                jobsStats.Add(currentDate, 0);
                foreach (var jobLine in jobLines)
                {
                    if (IsActiveJob(jobLine, currentDate))
                    {
                        jobsStats[currentDate] = jobsStats[currentDate] + 1;
                    }
                }
            }
            return jobsStats;
        }


        private bool IsActiveJob(JobLine job, DateTime currentDate)
        {
            if (job.DateOpen <= currentDate)
            {
                if (job.DateClose == null) return true;
                else if (job.DateClose >= currentDate) return true;
            }

            return false;
        }
    }
}
