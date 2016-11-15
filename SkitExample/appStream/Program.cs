﻿using System;
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
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://ru.wikipedia.org/wiki/%D0%97%D0%B0%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D1%81%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0");
            using(WebResponse response = request.GetResponse())
            using(Stream responseStream = response.GetResponseStream())
            using(FileStream output = File.Create("wiki.dat"))
            {
                StreamUtil.Copy(responseStream, output);
            }
        }
    }
}
