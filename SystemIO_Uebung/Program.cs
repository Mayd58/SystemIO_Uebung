using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO_Uebung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempDirectory = @"C:\Mert";
            string subdir = tempDirectory + @"\NET";
            string subdir1 = tempDirectory + @"\SUBNET";

            Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");

            if (!Directory.Exists(tempDirectory))
            {
                Directory.CreateDirectory(tempDirectory);
                Console.WriteLine($"Directory {tempDirectory} was created");
            }
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
                Console.WriteLine($"Directory {subdir} was created");
            }
            if (!Directory.Exists(subdir1))
            {
                Directory.CreateDirectory(subdir1);
                Console.WriteLine($"Directory {subdir1} was created");
            }

            Directory.Delete(subdir);


            //Directory.Move(subdir, subdir1 + @"\Lukas");
            Console.ReadLine();
        }
    }
}
