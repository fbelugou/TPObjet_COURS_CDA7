using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_HeritageVecteur
{
    internal class Vecteur3D : Vecteur2D
    {
        public float Z { get; private set; }

        public Vecteur3D() : base(0,0)
        {
            Z = 0;
        }

        public Vecteur3D(float x, float y, float z) : base(x, y)
        {
            Z = z;
        }

        public Vecteur3D(Vecteur3D vecteur3D) : 
            this(vecteur3D.Abscisse, vecteur3D.Ordonne, vecteur3D.Z) { }

        public override string? ToString()
        {
            return base.ToString() + $"- Z : {Z}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Vecteur3D d &&
                   base.Equals(obj) &&
                   Abscisse == d.Abscisse &&
                   Ordonne == d.Ordonne &&
                   Z == d.Z;
        }

        public override double Norme()
        {
            return Math.Sqrt(Math.Pow(Abscisse, 2) + Math.Pow(Ordonne, 2) + Math.Pow(Z, 2));
        }
    }
}
