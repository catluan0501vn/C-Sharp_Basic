using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SuDungClass
{
    class Program
    {
        static void Main(string[] args)
        {
            XinChao xinChao = new XinChao();
            Console.WriteLine(xinChao.Chao("Tran Binh Cat Luan"));
            Console.WriteLine("=========================");
            Console.WriteLine("PT Bac 1:");
            #region Giai PT Bac 1:
            //try
            //{
            //    //PTBac1 pTBac1 = new PTBac1();
            //    PTBac1 pTBac1 = new PTBac1(0, 2);
            //    Console.WriteLine(pTBac1.nghiemX);

            //    //pTBac1.SoA = 0;
            //    //pTBac1.SoB = 1;
            //    //pTBac1.GiaiPT();
            //    //Console.WriteLine("Nghiem PT la: {0}", pTBac1.nghiemX);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Giai PT Bac 2:
            //Console.WriteLine("=========================");
            //Console.WriteLine("PT Bac 2:");
            //double a = NhapSo("Nhap So A:");
            //double b = NhapSo("Nhap So B:");
            //double c = NhapSo("Nhap So C:");
            //try
            //{
            //    PTBac2 pTBac2 = new PTBac2(a, b, c);
            //    //Console.WriteLine(pTBac2.NghiemX1);
            //    //Console.WriteLine(pTBac2.NghiemX2);

            //    //pTBac2.SoA = 5;
            //    //pTBac2.SoB = 40;
            //    //pTBac2.SoC = 10;
            //    pTBac2.GiaiPTBac2();
            //    Console.WriteLine("Nghiem 1 PT la: {0}", pTBac2.NghiemX1);
            //    Console.WriteLine("Nghiem 2 PT la: {0}", pTBac2.NghiemX2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Hinh Hoc:
            Console.WriteLine("==================");
            Console.WriteLine("Hinh Tron");
            HinhTron ht = new HinhTron();
            ht.BK = NhapSo("Nhap Ban Kinh:");
            Console.WriteLine("Chu vi hinh tron: {0}", ht.ChuVi());
            Console.WriteLine("Dien tich hinh tron: {0}", ht.DienTich());

            Console.WriteLine("==================");
            Console.WriteLine("Hinh Tam Giac");
            HinhTamGiac htg = new HinhTamGiac();
            try
            {
                htg.CanhA = NhapSo("Nhap Canh A:");
                htg.CanhB = NhapSo("Nhap Canh B:");
                htg.CanhC = NhapSo("Nhap Canh C:");

                Console.WriteLine("Chu vi hinh tron: {0}", htg.ChuVi());
                Console.WriteLine("Dien tich hinh tron: {0}", htg.DienTich());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("==================");
            Console.WriteLine("Hinh Vuong");
            HinhVuong hv = new HinhVuong();
            hv.CanhHV = NhapSo("Nhap Canh Hinh Vuong:");
            Console.WriteLine("Chu vi hinh tron: {0}", hv.ChuVi());
            Console.WriteLine("Dien tich hinh tron: {0}", hv.DienTich());

            #endregion
            Console.ReadKey();
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
    }
}
