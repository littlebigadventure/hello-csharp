﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace appStream
{
    public static class StreamUtil
    {
        const int BufferSize = 8192;
        public static void Copy(Stream input, Stream output)
        {
            byte[] buffer = new byte[BufferSize];
            int read;
            while((read = input.Read(buffer, 0, buffer.Length))>0)
            {
                output.Write(buffer, 0, read);
            }
        }
        public static byte[] ReadFully(Stream input)
        {
            using(MemoryStream tempStream = new MemoryStream())
            {
                Copy(input, tempStream);
                return tempStream.ToArray();
            }

        }
    }
}
