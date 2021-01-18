using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Models
{


    public class JobLine
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime? DateClose { get; set; }
    }

}
