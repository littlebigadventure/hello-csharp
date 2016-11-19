using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkeetySoft.Model;
using System.Collections;
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
        public static void SimpleSelectName()
        {
            var query = from user in SampleData.AllUsers
                        select user.Name;
            foreach (var user in query)
            {
                Console.WriteLine(user);
            }
        }
        /// <summary>
        /// При использовании явно типизированной
        /// переменной диапазона автоматически вызывается Cast()
        /// </summary>
        public static void SelectSubstring()
        {
            ArrayList list = new ArrayList { "First", "Second", "Thisrd" };
            var strings = from string entry in list
                          select entry.Substring(0, 3);
            foreach(string start in strings)
            {
                Console.WriteLine(start);
            }
        }
    }
}
