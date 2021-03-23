using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_UngDung2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Birthyear");
            int birthYear = int.Parse(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            int age = dateTime.Year - birthYear;

            Console.WriteLine("Your age is {0} ", age);
            Console.ReadKey();

        }
    }
}
