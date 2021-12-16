using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungClass
{
    class HinhTron : HinhHoc
    {
        public double BK { get; set; }
        public override double ChuVi()
        {
            return 2* Math.PI* BK;
        }

        public override double DienTich()
        {
            return Math.Pow(BK, 2) * Math.PI;
        }
    }
}
