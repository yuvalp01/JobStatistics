using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoGReact
{
    public static class Extensions
    {
        public static long GetTime(this DateTime dateTime)
        {
            var time = (dateTime.ToUniversalTime() - new DateTime(1970, 1, 1));
            return (long)(time.TotalMilliseconds + 0.5);
        }
    }
}
