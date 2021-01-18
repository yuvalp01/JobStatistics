using PandoGReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact
{
    public class Mocks
    {
        public static List<JobLine> CreateFakeJobLines()
        {

            List<JobLine> lines = new List<JobLine>();
            lines.Add(new JobLine { Id = 1, DateOpen = new DateTime(2020, 5, 1 ), DateClose = new DateTime(2020,5,3) });
            lines.Add(new JobLine { Id = 2, DateOpen = new DateTime(2020, 5, 1 ), DateClose = new DateTime(2020,5,4) });
            lines.Add(new JobLine { Id = 3, DateOpen = new DateTime(2020, 5, 2 ), DateClose = new DateTime(2020, 5, 6) });
            lines.Add(new JobLine { Id = 4, DateOpen = new DateTime(2020, 5, 3 ), DateClose = null });
            lines.Add(new JobLine { Id = 5, DateOpen = new DateTime(2020, 5, 4 ), DateClose = null });
            lines.Add(new JobLine { Id = 6, DateOpen = new DateTime(2020, 5, 5 ), DateClose = null });
            lines.Add(new JobLine { Id = 7, DateOpen = new DateTime(2020, 5, 6 ), DateClose = null });
            lines.Add(new JobLine { Id = 8, DateOpen = new DateTime(2020, 5, 7 ), DateClose = null });
            lines.Add(new JobLine { Id = 9, DateOpen = new DateTime(2020, 5, 8 ), DateClose = null });
            lines.Add(new JobLine{ Id = 10, DateOpen = new DateTime(2020, 5, 9 ), DateClose = null });
            lines.Add(new JobLine{ Id = 10, DateOpen = new DateTime(2020, 5, 9 ), DateClose = null });
            return lines;

        }

        public static List<JobLine> CreateFakeViewLines()
        {

            List<JobLine> lines = new List<JobLine>();
            lines.Add(new JobLine { Id = 1, DateOpen = new DateTime(2020, 5, 1), DateClose = new DateTime(2020, 5, 3) });
            lines.Add(new JobLine { Id = 2, DateOpen = new DateTime(2020, 5, 1), DateClose = new DateTime(2020, 5, 4) });
            lines.Add(new JobLine { Id = 3, DateOpen = new DateTime(2020, 5, 2), DateClose = new DateTime(2020, 5, 8) });
            lines.Add(new JobLine { Id = 4, DateOpen = new DateTime(2020, 5, 3), DateClose = null });
            lines.Add(new JobLine { Id = 5, DateOpen = new DateTime(2020, 5, 4), DateClose = null });
            lines.Add(new JobLine { Id = 6, DateOpen = new DateTime(2020, 5, 5), DateClose = null });
            lines.Add(new JobLine { Id = 7, DateOpen = new DateTime(2020, 5, 6), DateClose = null });
            lines.Add(new JobLine { Id = 8, DateOpen = new DateTime(2020, 5, 7), DateClose = null });
            lines.Add(new JobLine { Id = 9, DateOpen = new DateTime(2020, 5, 8), DateClose = null });
            lines.Add(new JobLine { Id = 10, DateOpen = new DateTime(2020, 5, 9), DateClose = null });
            return lines;

        }


    }
}
