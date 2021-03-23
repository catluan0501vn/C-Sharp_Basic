using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VongLap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vòng Lặp For:
            //SudungVongLapFor();
            //TinhTongTuMotDenSoN();
            //TinhGiaiThua();
            //BangCuuChuong();
            //BangCuuChuongMotDenChin();
            //TinhDienTichHinhVuong();
            //TinhDienTichHinhChuNhat();
            //TinhDienTichHinhTron();
            HamMenu();
            Console.ReadKey();
        }

        private static void TinhDienTichHinhTron()
        {
            Console.WriteLine("Nhap so dien tich HCN ban muon tinh:");
            Console.WriteLine("Nhap BK:");
            double bk;
            double.TryParse(Console.ReadLine(), out bk);
            double p = 2;
            Console.WriteLine("Dien Tich Hinh Tron = {0}", Math.Pow(bk, 2)*Math.PI);

        }

        private static void TinhDienTichHinhChuNhat()
        {
            Console.WriteLine("Nhap so dien tich HCN ban muon tinh:");
            double dai;
            double.TryParse(Console.ReadLine(), out dai);
            double rong;
            double.TryParse(Console.ReadLine(), out rong);
            Console.WriteLine("Dien Tich Hinh Chu Nhat = {0}", dai * rong);
        }

        private static void TinhDienTichHinhVuong()
        {
            Console.WriteLine("Nhap so dien tich ban muon tinh:");
            double n;
            double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Dien Tich Hinh Vuong = {0}", n * n);
        }

        private static void HamMenu()
        {
            string chon = Console.ReadLine();
            if (chon == "Close")
            {
                return;
            }    
            switch (chon)
            {
                case "1":
                    BangCuuChuongMotDenChin();
                    break;
                case "2":
                    TinhGiaiThua();
                    break;
                case "3":
                    TinhGiaiThua();
                    break;
                case "4":
                    TinhDienTichHinhVuong();
                    break;
                case "5":
                    TinhDienTichHinhChuNhat();
                    break;
                case "6":
                    TinhDienTichHinhTron();
                    break;
            }
            HamMenu();
        }

        private static void BangCuuChuongMotDenChin()
        {
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Bang Cuu Chuong {0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, j * i);
                }
            }
        }


        private static void BangCuuChuong()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", 2, 1, 2*i);
            }

        }

        /// <summary>
        /// Viết cách tính Giai Thừa:
        /// </summary>
        private static void TinhGiaiThua()
        {
            Console.WriteLine("Nhap N:");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine("Ket qua = {0}", giaiThua);
        }

        private static void TinhTongTuMotDenSoN()
        {
            Console.WriteLine("Nhap so nguyen N:");
            int n;
            int tong = 0;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("So n la {0}", n);
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            Console.WriteLine("So tu 1 toi N la: {0}", tong);
        }

        private static void SudungVongLapFor()
        {
            for (int i = 0; i <= 10; i++)
            {
                //Console.WriteLine("Hello");
                //Console.WriteLine("Gia Tri Cua i: {0}", i);
                if (i % 2 == 0)
                {
                    Console.WriteLine("Cac so chan cua i la {0}", i);
                    Console.WriteLine("=======");
                }
                else
                {
                    Console.WriteLine("Cac so le cua i la {0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
