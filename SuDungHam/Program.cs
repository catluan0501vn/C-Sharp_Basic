using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("Nguyen Van Teo");
            //String CauXinChao = XinChao("Nguyen Van Teo");
            //Console.WriteLine(CauXinChao);
            //double a = NhapSo("NhapSoA");
            //PTBac1();
            //PTBac2();
            //NhapSoNguyen("NhapSoNguyen");
            //TimUocChungLonNhat();
            //TinhTongTuMotToiN();
            GiaiThua();
            Console.ReadKey();
        }

        private static void GiaiThua()
        {
            Console.WriteLine("Tinh Giai Thua");
            int n = NhapSoNguyen("Nhap vao giai thua N:");
            int giaiThua = TinhGiaiThua(n);

            Console.WriteLine("Ket qua = {0}", giaiThua);

        }

        private static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }

        private static void TinhTongTuMotToiN()
        {
            Console.WriteLine("Nhap So Nguyen:");
            int n = NhapSoNguyen("Nhap So N");
            int tong = TinhTu1DenN(n);

            Console.WriteLine("So tu 1 toi N la: {0}", tong);
        }

        private static int TinhTu1DenN(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }

        private static void TimUocChungLonNhat()
        {
            Console.WriteLine("Nhap 2 So Nguyen Duong");
            int a = NhapSoNguyen("Nhap so A");
            int b = NhapSoNguyen("Nhap So B");
            int ucln = TimUCLN(a, b);
           

            Console.WriteLine("Uoc Chung Lon Nhat La {0}", ucln);
        }

        private static int TimUCLN(int a, int b)
        {
            while (a * b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        private static int NhapSoNguyen(string v)
        {
            int a;
            bool kt;
            Console.WriteLine(v);
            do
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if(a < 0)
                {
                    kt = false;
                }    
            } while (kt == false);
            return a;
        }

        private static void PTBac2()
        {
            double a = NhapSo("Nhap So A");
            double b = NhapSo("Nhap So B");
            double c = NhapSo("Nhap So C");
            try
            {
                double[] x = GiaiPhuongTrinhBac2(a, b, c);
                Console.WriteLine("{0},{1}",x[0],x[1]);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static double[] GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            double[] x = new double[2];
            if(a == 0)
            {
                throw new Exception("Khong la PT Bac 2");
            }
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                throw new Exception("PT vo nghiem");
            }
            x[0] = (-b + Math.Sqrt(d)) / 2 * a;
            x[1] = (-b - Math.Sqrt(d)) / 2 * a;

            return x;
        }

        private static void PTBac1()
        {
            double a = NhapSo("NhapSoA");
            double b = NhapSo("NhapSoB");
            
            try
            {
                double x = GiaiPhuongTrinhBac1(a, b);
                Console.WriteLine(x);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        private static double GiaiPhuongTrinhBac1(double a, double b)
        {
            if(a == 0)
            {
                if(b == 0)
                {
                    throw new Exception("PT vo so nghiem");
                }    
                else
                {
                    throw new Exception("PT vo nghiem");
                }    
            }
            return -b / a;
        }

        private static double NhapSo(string v)
        {
            double a;
            bool kt;
            Console.WriteLine(v);
            do
            {
              kt = double.TryParse(Console.ReadLine(), out a);
            } while (kt == false);
            return a;
        }

        /// <summary>
        /// Xin Chao Co Tham So
        /// </summary>
        /// <param name="v"></param>
        private static string XinChao(string v)
        {
            return String.Format("Xin chao: {0}", v);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chao");
        }
    }
}
