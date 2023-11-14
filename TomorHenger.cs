using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hemger
{
    public class TomorHenger : Henger
    {
        private double fs = 7.87;


        public TomorHenger(double r, double m) : base(r, m) { }

        public TomorHenger(double r, double m, double fs) : base(r, m)
        {
            this.fs = fs;
        }

        public double Suly()
        {
            return Fs * Terfogat();
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Math.Round(Terfogat(),2)}; sugár: {R}; magasság: {M}; fajsúly: {Fs}";
        }
        public double Fs { get => fs; }
    }
}
