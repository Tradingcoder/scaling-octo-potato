﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime;
using System.Runtime.InteropServices;

namespace MappedMemory
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting... Current GC mode: {0}, Is server GC: {1}",
                      GCSettings.LatencyMode, GCSettings.IsServerGC);
            Console.WriteLine("Setting GCSettings to SustainedLowLatency");
            GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;
            Console.WriteLine("Current GC mode: {0}, Is server GC: {1}",
                   GCSettings.LatencyMode, GCSettings.IsServerGC);




            long offset = 0x10000000; // 256 megabytes 
            long length = 0x20000000; // 512 megabytes 

            // Create the memory-mapped file. 
            using (var mmf = MemoryMappedFile.CreateFromFile(@"c:\temp\test.txt", FileMode.Open, "ImgA"))
            {
                // Create a random access view, from the 256th megabyte (the offset) 
                // to the 768th megabyte (the offset plus length). 
                using (var accessor = mmf.CreateViewAccessor(offset, length))
                {
                    int colorSize = Marshal.SizeOf(typeof(MyColor));
                    MyColor color;

                    // Make changes to the view. 
                    for (long i = 0; i < length; i += colorSize)
                    {
                        accessor.Read(i, out color);
                        color.Brighten(10);
                        accessor.Write(i, ref color);
                    }
                }
            }
        }
    }

    public struct MyColor
    {
        public short Red;
        public short Green;
        public short Blue;
        public short Alpha;

        // Make the view brighter. 
        public void Brighten(short value)
        {
            Red = (short)Math.Min(short.MaxValue, (int)Red + value);
            Green = (short)Math.Min(short.MaxValue, (int)Green + value);
            Blue = (short)Math.Min(short.MaxValue, (int)Blue + value);
            Alpha = (short)Math.Min(short.MaxValue, (int)Alpha + value);
        }
    }
}