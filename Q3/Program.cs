using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isheader = true;
            var reader = new StreamReader(File.OpenRead(@"C:\Users\ahmed\Desktop\csvv.csv"));
            List<string> headers = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                if (isheader)
                {
                    isheader = false;
                    headers = values.ToList();
                   
                }
                else
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        Console.Write(string.Format("{0} = {1};", headers[i], values[i]));                        
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
