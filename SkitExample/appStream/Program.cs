using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace appStream
{
    class Program
    {
        static void DemoStream()
        {
            WebRequest request = WebRequest.Create("https://ru.wikipedia.org/wiki/%D0%97%D0%B0%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D1%81%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0");
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream output = File.Create("wiki.dat"))
            {
                StreamUtil.Copy(responseStream, output);
            }
        }
        static void DemoReverse()
        {
            var collection = Enumerable.Range(0, 10);
            collection = Enumerable.Where(collection, x=> x % 2 !=0);
            collection = Enumerable.Reverse(collection);
            foreach(var i in collection)
            {
                Console.WriteLine(i);
            }
        }
        static void DemoSqrt()
        {
            var collection = Enumerable.Range(0, 10)
                .Where(x => x % 2 != 0)
                .Reverse()
                .Select(x => new { Original = x, SquareRoot = Math.Sqrt(x) });

            foreach( var element in collection)
            {
                Console.WriteLine("sqrt({0}) = {1}",element.Original, element.SquareRoot);
            }
        }
        static void DemoSquare()
        {
            var collection = Enumerable.Range(-5, 11)
                .Select(x => new { Original = x, Square = x * x })
                .OrderBy(x => x.Square)
                .ThenBy(x => x.Original);
            foreach(var element in collection)
            {
                Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            DemoSquare();
            Console.ReadLine();
        }
    }
}
