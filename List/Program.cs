using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            listInt.Add(10);
            listInt.Add(5);
            listInt.Add(8);
            listInt.Add(9);
            listInt.Add(36);
            listInt.Add(14);
            listInt.Add(72);

            listInt.RemoveAll(item => item >= 10);

            //for (int i = 0; i < listInt.Count; i++)
            //{
            //    Console.WriteLine("For In Ra: {0}", listInt[i]);

            //}
            //foreach (var item in listInt)
            //{
            //    Console.WriteLine("Foreach In Ra: {0}", item);
            //}

            for(int i = 0; i < listInt.Count; i++)
            {
                Console.WriteLine("Day So Tang Dan: {0}", listInt[i]);
            }    

            Console.ReadKey();

        }
    }
}
