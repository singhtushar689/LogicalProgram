using System.Diagnostics;
using System.Globalization;

namespace LogicalProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            stopwatch.Stop();

            Console.WriteLine($"Time elapsed:  {stopwatch.Elapsed}");
        }     
             
    }
}