using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_SoSanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tim So Lơn Nhat");

            #region Cach 1
            //Console.WriteLine("Nhap A");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap B");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap C");
            //double c = double.Parse(Console.ReadLine());

            
            //if (a > b)
            //{
            //    if(a > c)
            //    {
            //        Console.WriteLine("So a la So Lon Nhat");
            //    }    
            //    else
            //    {
            //        Console.WriteLine("So b la So Lon Nhat");
            //    }    
            //}
            //else
            //{
            //    if (b < c)
            //    {
            //        Console.WriteLine("So c la So Lon Nhat");
            //    }
            //    else
            //    {
            //        Console.WriteLine("So b la So Lon Nhat");
            //    }
            //}
            #endregion

            #region Cach 2
            Console.WriteLine("Nhap A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C");
            double c = double.Parse(Console.ReadLine());
            double max = a;

            if(max < b)
            {
                max = b;
            }    
            if(max < c)
            {
                max = c;
            }
            Console.WriteLine("Trong ba so {0} ,{1} ,{2} So lon nhat la {3}",
                                a, b, c, max);
            #endregion

            Console.ReadKey();
        }
    }
}
