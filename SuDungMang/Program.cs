using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestMang();
            //TimSoLonNhatTrongMang();
            //TimPhanTuMang();
            //SapXepMang1();
            SapXepMang2();
            //NhapMang();

            Console.ReadKey();
        }

        private static void SapXepMang2()
        {
            int[] a = { 2, 25, 36, 78, 21 };
            for (int j = 0; j < a.Length; j++)
            {
                int max = a[j];
                for (int i = j; i < a.Length; i++)
                {
                    if (a[max] > a[j])
                    {
                        max = i;
                    }
                }
                int tmp = a[max];
                a[max] = a[j];
                a[j] = tmp;
                //Console.WriteLine("So lon nhat trong mang la: {0}", max);

            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        private static void NhapMang()
        {
            Console.WriteLine("Nhap so phan tu mang");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap {0} phan tu vao trong mang:\n", i);
                int.TryParse(Console.ReadLine(), out a[i]);
            }
            Console.WriteLine("Mang vua nhap la:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void SapXepMang1()
        {
            int[] a = { 2, 25, 36, 78, 21};
            int i = 0; 

            while (true)
            {
                if (a[i] > a[i + 1])
                {
                    int tmp;
                    tmp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tmp;
                    i = 0;
                }
                else
                    i++;
                if (i + 1 >= a.Length)
                {
                    break;
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }

            //for (int i = 0; i < a.Length - 1;)
            //{
            //    if (a[i] > a[i + 1])
            //    {
            //        int tmp;
            //        tmp = a[i];
            //        a[i] = a[i + 1];
            //        a[i + 1] = tmp;
            //        i = 0;
            //    }
            //    else
            //        i++;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
        }

        private static void TimPhanTuMang()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int tim;
            string t = Console.ReadLine();
            bool kt = false;
            if (t == "Close")
                return;
            Console.WriteLine("Nhap gia tri ban muon tim");
            int.TryParse(t, out tim);
            for (int i = 0; i < a.Length; i++)
            {
                if(tim == a[i])
                {
                    Console.WriteLine("{0} Tim o vi tri thu {1}", tim, i);
                    kt = true;
                }    
            }
            if(kt == false)
            {
                Console.WriteLine("Khong tim thay {0} phan tu nay trong mang !", tim);
            }
            TimPhanTuMang();
        }

        private static void TimSoLonNhatTrongMang()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2==0)
                {
                    Console.WriteLine("So chan la {0}", a[i]);
                }    
                else
                {
                    Console.WriteLine("So le la {0}", a[i]);
                }    
            }

            //int max = a[0];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (max < a[i])
            //        max = a[i];

            //}
            //Console.WriteLine("Phan tu lon nhat trong mang la {0}", max);

            //int min = a[0];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > a[i])
            //        min = a[i];

            //}
            //Console.WriteLine("Phan tu nho nhat trong mang la {0}", min);
        }

        private static void TestMang()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            int[] b = new int[6];
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Nhap PT thu {0}", i);
                int.TryParse(Console.ReadLine(), out b[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
