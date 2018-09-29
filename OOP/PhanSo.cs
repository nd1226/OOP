using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo() { }
        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public void inIT(int tu,int mau)
        {
            TuSo = tu;
            MauSo = mau;
        }
        public void Print()
        {
            int ucln = UCLN(TuSo, MauSo);
            Console.WriteLine("{0}/{1}", TuSo / ucln, MauSo / ucln);
        }
        private int UCLN(int a,int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if(a==0 && b != 0)
            {
                return a;
            }else if(a!= 0&& b == 0)
            {
                return b;
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
            }
            
            return a;
        }
        public PhanSo Cong(PhanSo p)
        {
            int tuSo = TuSo * p.MauSo + p.TuSo * MauSo;
            int mauSoChung;
            if(MauSo == p.MauSo)
            {
                mauSoChung = MauSo;
            }
            else
            {
                mauSoChung = MauSo * p.MauSo;
            }
            return new PhanSo(tuSo, mauSoChung);
        }
    }
}
