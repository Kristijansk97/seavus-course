using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class NumberHelper
    {
        public static int GetRandomId()
        {
            var rnd = new Random();
            return rnd.Next(1, int.MaxValue);
        }
    }
}
