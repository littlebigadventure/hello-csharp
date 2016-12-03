using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAsync
{
    class Program
    {
        static async Task<int> funcAsuncMov(int x)
        {
            Console.WriteLine("Starting...x={0}", x);
            await Task.Delay(x * 1000);
            Console.WriteLine("Finished...x={0}", x);
            return x;
        }

        static void Main(string[] args)
        {
            Task<int> first = funcAsuncMov(5);
            Task<int> second = funcAsuncMov(3);
            Task<int> third = funcAsuncMov(1);
            Console.ReadLine();
        }
    }
}
