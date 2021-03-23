using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungClass
{
    class PTBac1
    {
        public PTBac1(double soA, double soB)
        {
            SoA = soA;
            SoB = soB;
            //this.nghiemX = nghiemX;
            GiaiPT();
        }

        public double SoA { get; set; }
        public double SoB { get; set; }
        public double nghiemX { get; set; }

        public void GiaiPT()
        {
            if(SoA == 0)
            {
                if(SoB == 0)
                {
                    throw new Exception("PT vo so nghiem");
                }    
                else
                {
                    throw new Exception("PT vo nghiem");
                }    
            }
            nghiemX = -SoB / SoA;
        }

    }
}
