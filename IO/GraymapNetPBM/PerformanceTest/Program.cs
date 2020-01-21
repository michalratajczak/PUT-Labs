using System;
using GraymapLibrary.Operations;
using GraymapLibrary.Maps;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace PerformanceTest
{
    class Program
    {       

        static void Main(string[] args)
        {
            RepeatableTest(50, 10, 30);


            Console.ReadKey();
        }

        static void RepeatableTest(int imageSizeStep, int testRepeats, int numberOfTests)
        {
            List<string> lines = new List<string>(numberOfTests * 9);

            for(int i = 1; i <= numberOfTests; i++)
            {                
                for(int f = 3; f <= 21; f+=2)
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append($"{ i * imageSizeStep };{ f };");

                    for (int l = 0; l < testRepeats; l++)
                    {
                        Graymap graymap = Generator.HorizontalStripes(i * imageSizeStep, i * imageSizeStep, new int[] { 0, 255 }, imageSizeStep / 5);

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Filtering.ApplyFilter(graymap, GraymapLibrary.Filters.Generator.GetGaussianBlur(f));
                        stopwatch.Stop();

                        builder.Append($"{ stopwatch.ElapsedMilliseconds };");
                        Console.WriteLine($"Blur size: { f.ToString("D2") } | Image size: { i * imageSizeStep } | Regular iteration: { stopwatch.ElapsedMilliseconds }ms");
                    }

                    lines.Add(builder.ToString().Substring(0, builder.ToString().Length - 1));
                }              
            }

            File.WriteAllLines("regular.csv", lines.ToArray());

            //=======================================================================================================================

            lines = new List<string>(numberOfTests * 9);

            for (int i = 1; i <= numberOfTests; i++)
            {
                for (int f = 3; f <= 21; f += 2)
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append($"{ i * imageSizeStep };{ f };");

                    for (int l = 0; l < testRepeats; l++)
                    {
                        Graymap graymap = Generator.HorizontalStripes(i * imageSizeStep, i * imageSizeStep, new int[] { 0, 255 }, imageSizeStep / 4);

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Filtering.ApplyFilterParallel(graymap, GraymapLibrary.Filters.Generator.GetGaussianBlur(f));
                        stopwatch.Stop();

                        builder.Append($"{ stopwatch.ElapsedMilliseconds };");
                        Console.WriteLine($"Blur size: { f.ToString("D2") } | Image size: { i * imageSizeStep } | Parallel iteration: { stopwatch.ElapsedMilliseconds }ms");
                    }

                    lines.Add(builder.ToString().Substring(0, builder.ToString().Length - 1));
                }
            }

            File.WriteAllLines("parallel.csv", lines.ToArray());
        }
        

        
    }
}
