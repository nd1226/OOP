using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class TamGiac
    {
        public Point DiemA { get; set; }
        public Point DiemB { get; set; }
        public Point DiemC { get; set; }
        public TamGiac(Point diemA, Point diemB, Point diemC)
        {
            DiemA = diemA;
            DiemB = diemB;
            DiemC = diemC;
        }
        public double ChuVi()
        {
            return DiemA.KhoangCach(DiemB) + DiemA.KhoangCach(DiemC) + DiemB.KhoangCach(DiemC);
        }
        public double DienTich() {
            double p = ChuVi() / 2;
            return Math.Sqrt((p-DiemA.KhoangCach(DiemB)) * (p-DiemA.KhoangCach(DiemC)) * (p-DiemB.KhoangCach(DiemC)));
        }
    }
}
