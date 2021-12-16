using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PTBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c");
            double c = int.Parse(Console.ReadLine());
    
            if(a == 0)
            {
                Console.WriteLine("Khong la PT Bac 2");
            }    
            else
            {
                double d = b * b - 4 * a + c;

                d = Math.Pow(b, 2) - 4 * a * c;
                if(d >= 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(d)) / 2 * a;

                    Console.WriteLine("PHuong trinh co nhiem thu nhat {0}", x1);
                    Console.WriteLine("PHuong trinh co nhiem thu hai {0}", x2);
                }
                else
                {
                    Console.WriteLine("PT Vo Nghiem");
                }    

            }    

            Console.ReadKey();
        }
    }
}
