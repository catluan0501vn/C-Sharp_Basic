using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace SuDungClass
{
    class PTBac2
    {
        public  double SoA { get; set; }
        public double SoB { get; set; }
        public double SoC { get; set; }
        public double Delta { get; set; }
        public double NghiemX1 { get; set; }
        public double NghiemX2 { get; set; }

        //Create Constructor:
        public PTBac2(double soA, double soB, double soC)
        {
            SoA = soA;
            SoB = soB;
            SoC = soC;
            GiaiPTBac2();
        }

        public void GiaiPTBac2()
        {
            
            if (SoA == 0)
            {
                throw new Exception("Khong la PT Bac 2");
            }
            Delta = Math.Pow(SoB, 2) - 4 * SoA * SoC;
            if(Delta < 0)
            {
                throw new Exception("PT vo nghiem");
            }    
            NghiemX1 = (-SoB + Math.Sqrt(Delta)) / 2 * SoA;
            NghiemX2 = (-SoB - Math.Sqrt(Delta)) / 2 * SoA;
        }
    }
}
