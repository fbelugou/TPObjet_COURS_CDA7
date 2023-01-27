using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Formes_Geometrique
{
    internal class Segment 
    {
        public Point Debut { get; private set; }

        public Point Fin { get; private set; }

        public Segment(Point debut, Point fin)
        {
            Debut = debut;
            Fin = fin;
        }

        public double Longueur()
        {
            return Debut.Distance(Fin);
        }

        public override string? ToString()
        {
            return $"Début: {Debut}, Fin:{Fin}) - Long: {Longueur()}";
        }
    }
}
