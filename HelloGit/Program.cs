using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World");
                Console.WriteLine("Hello USA");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception has occured");
            }
        }

        public static void LogChanges()
        {
            Console.WriteLine("Write to Log");
        }

            }
}
