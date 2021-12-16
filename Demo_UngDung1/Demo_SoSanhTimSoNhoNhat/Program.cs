using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_SoSanhTimSoNhoNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C");
            double c = double.Parse(Console.ReadLine());
            double min = a;

            if(min > b)
            {
                min = b;
            }    
            if(min > c)
            {
                min = c;
            }
            Console.WriteLine("Trong ba so {0} ,{1} ,{2} So nho nhat la {3}",
                                a, b, c, min);

            Console.ReadKey();
        }
    }
}
