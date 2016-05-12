using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson_1
{
   public class Program
    {
        static void Main(string[] args)
        {
            HelloToConsole();
        }

        public static string HelloToConsole()
        {
            string write = "Hello world";
            Console.WriteLine(write);
            return write;

        }
    }
}
