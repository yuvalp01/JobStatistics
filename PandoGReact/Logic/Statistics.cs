using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Logic
{
    public class Statistics
    {


      



        public Dictionary<DateTime, int> CalcStats(List<JobLine> jobLines)
        {

            //var dates = jobLines.Select(a => new KeyValuePair<DateTime, int>(a.DateOpen, 0)).Distinct();
            //Dictionary<DateTime, int> jobsStats = new Dictionary<DateTime, int>();

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
                //var newJobs = jobLines.Where(a => a.DateOpen == currentDate);

            }
            return jobsStats;

          
            //DateTime date = new DateTime();

            //for (int i = 0; i < jobLines.Count; i++)
            //{
            //    if (i == 0 && IsActiveJob(jobLines[i]))
            //    {
            //        date = jobLines[i].DateOpen;
            //        jobsStats.Add(date, 1);

            //    }
            //    else if (jobLines[i].DateOpen == date)
            //    {
            //        if (IsActiveJob(jobLines[i]))
            //        {
            //            jobsStats[date] = jobsStats[date] + 1;
            //        }
            //    }
            //    else
            //    {
            //        date = jobLines[i].DateOpen;
            //        if (IsActiveJob(jobLines[i]))
            //        {
            //            jobsStats.Add(date, 1);
            //        }
            //    }
            //}

           // return jobsStats;

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
