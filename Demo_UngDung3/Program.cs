using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_UngDung3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number B");
            double b = double.Parse(Console.ReadLine());

            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("PT Vo So Nghiem");
                }    
                else
                {
                    Console.WriteLine("PT Vo Nghiem");
                }    
            }
            else
            {
                Console.WriteLine("PT co nghiem la {0}", -b/a);
            }    
            Console.ReadKey();
        }
    }
}
