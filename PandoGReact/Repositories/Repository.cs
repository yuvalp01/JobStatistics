using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Repositories
{
    public abstract class Repository
    {

        protected JobContext _context;
        public Repository(JobContext context)
        {
            _context = context;
        }


        protected List<object> GetTitles()
        {
            return new List<object> { "Date", "Job views", "Predicted jobs views", "Active jobs" };
        }

        /// <summary>
        /// This function return the data in a G charts array format
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<IEnumerable<object>> GetChartDataObject();

    }
}
