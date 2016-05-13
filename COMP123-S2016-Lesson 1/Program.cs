using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Mohamoud mohamed
 * Date Created: May 11, 2016
 * Date Modified: May 13, 2016
 * Student ID: 300435435
 * 
 * Description: This program shows GitHub and version control
 * also explore Unit Testing methods
 * */
namespace COMP123_S2016_Lesson_1
{/**
     * This is the driver class for our program
     * 
     * @class Program
     */
    public class Program
    { /**
         * Main Method for class Program
         * 
         * @param {string[]} args
         * @constructor Main
         */
        static void Main(string[] args)
        {
            HelloToConsole();
        }
        /**
         * This method outputs a string using a console class
         * @return write string
         
             */
        public static string HelloToConsole()
        {
            string write = "Hello world";
            Console.WriteLine(write);
            return write;

        }
    }
}
