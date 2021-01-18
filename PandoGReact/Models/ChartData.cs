using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Models
{


    public class DataPoint
    {
        public DateTime Date { get; set; }
        public int ActiveJobs { get; set; }
        public int JobViews { get; set; }
        public int ViewsPrediction { get; set; }
    }



    //public class ChartData
    //{
    //    public List<string> Titles { get; set; }
    //    public List<string> Jobs { get; set; }
    //    public List<string> JobViews { get; set; }
    //    public List<string> ViewsPrediction { get; set; }
    //}
}
