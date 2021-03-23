using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra_ĐTB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cách 1:
            Console.WriteLine("Nhap Diem");
            double diem;
            double.TryParse(Console.ReadLine(), out diem);

            Console.WriteLine(diem);

            if (diem >= 0 && diem <= 10)
            {
                if (diem <= 3.5)
                {
                    Console.WriteLine("Loai Yeu");
                }
                else if (diem < 5)
                {
                    Console.WriteLine("Loai TB");
                }
                else if (diem < 8)
                {
                    Console.WriteLine("Loai Kha");
                }
                else
                {
                    Console.WriteLine("Loai Gioi");
                }

            }
            else
            {
                Console.WriteLine("Diem khong hop le");
            }

            //Cách 2:


            Console.ReadKey();
        }
    }
}
