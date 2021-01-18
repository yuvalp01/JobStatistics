using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Models
{
    [Table("jobs")]
    public class Job
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        //public int Id { get; set; }
        //public string Title { get; set; }
        //public DateTime DateOpen { get; set; }
        //public DateTime DateClose { get; set; }
    }

    //public class StatsView
    //{
    //    public DateTime Date { get; set; }
    //    public int Count { get; set; }
    //}
}
