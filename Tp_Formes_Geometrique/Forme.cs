using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Formes_Geometrique;

internal abstract class Forme : IComparable<Forme>
{
    public Point Origine { get; private set; }

    protected Forme(Point origine)
    {
        Origine = origine;
    }

    public abstract double GetSurface();

    public abstract double GetPerimetre();

    public int CompareTo(Forme? other)
    {
        return (GetSurface() > other?.GetSurface()) ? 1 : -1;
    }
}
