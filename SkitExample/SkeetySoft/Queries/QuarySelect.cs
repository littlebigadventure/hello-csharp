using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkeetySoft.Model;
namespace SkeetySoft.Queries
{
    public static class QuarySelect
    {
        public static void SimpleSelect()
        {
            var query = from user in SampleData.AllUsers
                        select user;
            foreach(var user in query)
            {
                Console.WriteLine(user);
            }
        }
    }
}
