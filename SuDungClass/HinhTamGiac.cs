using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace SuDungClass
{
    class HinhTamGiac : HinhHoc
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }
        public double CanhC { get; set; }

        public override double ChuVi()
        {
            if (LaTamGiac())
                return CanhA + CanhB + CanhC;
            throw new Exception("Khong phai la hinh tam giac");
        }

        public override double DienTich()
        {
            bool kt = LaTamGiac();
            if (kt == false)
                throw new Exception("Khong la hinh Tam Giac");

            double p = ChuVi() / 2;
            double s = Math.Sqrt(p * (p - CanhA)
                                  * (p - CanhB)
                                  * (p - CanhC));
            return s;
        }

        private bool LaTamGiac()
        {
            if(CanhA + CanhB > CanhC
                && CanhA + CanhC > CanhC
                && CanhB + CanhB > CanhC)
            {
                return true;
            }
            return false;
        }
    }
}
