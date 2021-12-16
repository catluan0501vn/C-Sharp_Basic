using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungStruct
{
    struct SinhVien
    {
        public static List<SinhVien> dsSinhVien;
        public string MS { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }
        public DateTime NgaySinh { get; set; }


        public SinhVien(string mS, string ten, string sDT, string diaChi, string lop, string khoa, DateTime ngaySinh)
        {
            MS = mS;
            Ten = ten;
            SDT = sDT;
            DiaChi = diaChi;
            Lop = lop;
            Khoa = khoa;
            NgaySinh = ngaySinh;
            if(dsSinhVien == null)
            {
                dsSinhVien = new List<SinhVien>();
            }    
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|",
                                MS, Ten, SDT, DiaChi, Lop, Khoa, NgaySinh);
        }


        public void ThemSinhVien(SinhVien Teo)
        {
            if(dsSinhVien == null)
            {
                dsSinhVien = new List<SinhVien>();
            }    
            dsSinhVien.Add(Teo);

        }

        public void XoaSinhVien(string v)
        {
            int index = timViTriSV(v);
            if(index >= 0)
            {

            }    
            dsSinhVien.RemoveAt(index);
        }

        private int timViTriSV(string v)
        {
            int dem = -1;
            int i = 0;
            foreach (SinhVien sv in dsSinhVien)
            {
                if(sv.MS == v)
                {
                    dem = i;
                    break;
                }
                i++;
            }
            return dem;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //KhoiTaoSinhVien();
            //NhapTTSinhVien();
            SinhVien Teo = NhapTTSinhVien();
            SinhVien Ti = NhapTTSinhVien();
            Teo.ThemSinhVien(Teo);
            Teo.ThemSinhVien(Ti);

            Teo.XoaSinhVien("001");

            xuatDSSinhVien();

            Console.ReadKey();

        }
        /// <summary>
        /// Xuat DS Sinh Vien Ra Man Hinh:
        /// </summary>
        private static void xuatDSSinhVien()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Danh Sach Sinh Vien:");
            foreach (SinhVien sv in SinhVien.dsSinhVien)
            {
                Console.WriteLine(sv.ToString());
            }
        }

        private static SinhVien NhapTTSinhVien()
        {
            Console.WriteLine("Nhap Thong Tin Sinh Vien");
            SinhVien sv = new SinhVien();
            Console.WriteLine("MSSV:");
            sv.MS = Console.ReadLine();
            Console.WriteLine("Ho&Ten:");
            sv.Ten = Console.ReadLine();
            Console.WriteLine("SĐT:");
            sv.SDT = Console.ReadLine();
            Console.WriteLine("Dia Chi:");
            sv.DiaChi = Console.ReadLine();
            Console.WriteLine("Lop:");
            sv.Lop = Console.ReadLine();
            Console.WriteLine("Khoa:");
            sv.Khoa = Console.ReadLine();
            //Console.WriteLine("Ngay Sinh:");

            Console.WriteLine(sv.ToString());

            return sv;
        }

        private static void KhoiTaoSinhVien()
        {
            SinhVien Toan = new SinhVien()
            {
                MS = "123456",
                Ten = "Nguyen Van Toan",
                SDT = "0907993856",
                DiaChi = "TG",
                Lop = "OOP",
                Khoa = "ICT",
                NgaySinh = new DateTime(1996, 1, 5)
            };
            string ttSinhVien = Toan.ToString();

            Console.WriteLine(Toan.ToString());
        }
    }
}
