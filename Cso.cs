using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hemger
{
    public class Cso : Henger
    {
        private double fv = 1;
        private double fs = 0;


        public Cso(double r, double m) : base(r, m) { }

        public Cso(double r, double m, double fv) : base(r, m)
        {
            this.fv = fv;
        }

        public Cso(double r, double m, double fv, double fs) : base(r, m)
        {
            this.fv = fv*fs;
        }

        public override double Terfogat()
        {
            double r_belső = R - Fv;
            return Math.PI * M * (Math.Pow(R, 2) - Math.Pow(r_belső, 2));
        }


        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Math.Round(Terfogat(),2)}; sugár: {R}; magasság: {M}; falvastagsága: {Fv}" + ((Fs > 0) ? $"; fajsúly: {Fs}" : "");
        }
        public double Fv { get => fv; }
        public double Fs { get => fs; }
    }
}
