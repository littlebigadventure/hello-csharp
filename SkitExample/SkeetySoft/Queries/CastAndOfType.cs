using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeetySoft.Queries
{
    public static class CastAndOfType
    {
        public static void DemoCast()
        {
            ArrayList list = new ArrayList { "First", "Second", "Third" };
            IEnumerable<string> strings = list.Cast<string>();
            foreach(string item in strings)
            {
                Console.WriteLine(item);
            }
        }
        public static void DemoOfType()
        {
            ArrayList list = new ArrayList {1,"not an int", 2, 3, 4 };
            IEnumerable<int> ints = list.OfType<int>();
            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }

        }

    }
}
