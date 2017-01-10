using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileReadWrite
{
    public class Program
    {
        const int BufferSize = 1024;
        private static string fileName = @"The Constitution of the United States A Transcription.txt";
        public static void Main(string[] args)
        {
            string tempPath = Path.GetTempFileName();
            int bufferCounter = 0;
            Stopwatch timer = Stopwatch.StartNew();
            if (File.Exists(fileName))
            {
                using (StreamReader reader = File.OpenText(fileName))
                {
                    string buffer = null;
                    using (StreamWriter writer = new StreamWriter(tempPath))
                    {
                        writer.WriteLine(buffer);
                        bufferCounter++;
                    }
                }
                
            }
            timer.Stop();
            Console.WriteLine("Elapsed time  = {0} ms", timer.ElapsedMilliseconds);
            Console.WriteLine("Total number of bffers required : {0}", bufferCounter);
            Console.ReadLine();
        }
    }
}
