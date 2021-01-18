using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Models
{
    [Table("jobStats", Schema = "stats")]
    public class JobStat
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

    }


}
