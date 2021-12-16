using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SoSanhDaoNguocSo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int x, r, sum = 0, t;

            Console.Write("Nhap mot so bat ky: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (t = x; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }

            if(sum == x)
            {
                Console.WriteLine("So theo chieu dao nguoc cua {0}", sum);
                Console.ReadKey();
            }
            else
            {
                Console.Write("{0}", sum, "Khong bang so nhap vua nhap vao \n");
                Console.ReadKey();
            }
            
        }
    }
}
