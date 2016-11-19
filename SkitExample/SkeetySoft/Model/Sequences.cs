using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeetySoft.Model
{
    public static class Sequences
    {
        static int next = 1;
        public static int Next()
        {
            return next++;
        }
    }
}
