﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact.Models
{

    [Table("jobViews")]

    public class JobView
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

    }
}
