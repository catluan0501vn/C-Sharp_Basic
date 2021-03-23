using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace SuDungVongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            HamMenu();
            //TimUocChungLonNhat();

            Console.ReadKey();
        }

        private static void HamMenu()
        {
            Console.WriteLine("1 Vong Lap While");
            Console.WriteLine("2 Nhap So Nguyen Duong");
            Console.WriteLine("3 Tìm Uoc Chung Lon Nhat");
            Console.WriteLine("Nhap Tuy Chon Cua Ban:");
            String chon = Console.ReadLine();
            if(chon == "Exit")
            {
                return;
            }    
            switch(chon)
            {
                case "1":
                    VongLapWhileCoBan();
                    break;
                case "2":
                    NhapSoNguyenDuong();
                    break;
                case "3":
                    TimUocChungLonNhat();
                    break;
                default:
                    return;
            }

            HamMenu();
        }

        private static void TimUocChungLonNhat()
        {
            Console.WriteLine("Nhap 2 so Nguyen Duong");
            int a;
            int.TryParse(Console.ReadLine(), out a);
            int b;
            int.TryParse(Console.ReadLine(), out b);

            while(a * b > 0)
            {
                if(a > b)
                {
                    a = a % b;
                }    
                else
                {
                    b = b % a;
                }    
            }

            Console.WriteLine("Uoc Chung Lon Nhat La {0}", a + b);
        }

        private static void NhapSoNguyenDuong()
        {
            int a;
            Console.WriteLine("Nhap so Nguyen Duong");
            //bool kt = int.TryParse(Console.ReadLine(), out a);

            //if (kt == true)
            //    if (a == 0)
            //        kt = false;
            //while (kt == false)
            //{
            //    Console.WriteLine("Nhap sai, xin moi nhap lai !");

            //    kt = int.TryParse(Console.ReadLine(), out a);

            //    if (kt == true)
            //        kt = (a == 0) ? false : true;
            //}

            while (true)
            {
                bool kt = int.TryParse(Console.ReadLine(), out a);

                if(kt == true)
                {
                    if(a <= 0)
                    {
                        kt = false;
                    }    
                    else
                    {
                        break;
                    }    
                }
                if(kt == false)
                {
                    Console.WriteLine("Nhap sai, mơi nhap lai !");
                }    
            }
            

            //while (kt == false)
            //{
            //    Console.WriteLine("Nhap sai, xin moi nhap lai !");

            //    kt = int.TryParse(Console.ReadLine(), out a);
            //}
        }

        private static void VongLapWhileCoBan()
        {
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine("Xin chao");
                i++;
            }
        }
    }
}
