using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Models
{

    /// <summary>
    /// Helper object to parse the return statistical data
    /// </summary>
    public class DataPoint
    {
        public DateTime Date { get; set; }
        public int ActiveJobs { get; set; }
        public int JobViews { get; set; }
        public int ViewsPrediction { get; set; }
    }

}
