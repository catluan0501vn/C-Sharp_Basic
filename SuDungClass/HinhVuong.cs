using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungClass
{
    class HinhVuong : HinhHoc
    {
        public double CanhHV { get; set; }
        public override double ChuVi()
        {
            return CanhHV * 4;
        }

        public override double DienTich()
        {
            return CanhHV * 2;
        }
    }
}
