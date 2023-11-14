using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hemger
{
    public class Henger
    {
        private double r;
        private double m;
        private static int szuletesSzamlalo = 0;


        public Henger(double r, double m)
        {
            this.r = r;
            this.m = m;
            szuletesSzamlalo++;
        }

        public virtual double Terfogat()
        {
            return Math.PI * Math.Pow(R, 2) * M;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Math.Round(Terfogat(),2)}; sugár: {R}; magasság: {M}";
        }

        public double R { get => r; }
        public double M { get => m; }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }
    }
}
