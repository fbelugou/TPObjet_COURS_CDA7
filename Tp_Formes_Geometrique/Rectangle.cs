using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Formes_Geometrique;

internal class Rectangle : Forme
{
    public double Longueur { get; private set; }
    public double Largeur { get; private set; }

    public Rectangle(double longueur, double largeur, Point coinSuperieurGauche)
        : base(coinSuperieurGauche)
    {
        Longueur = longueur;
        Largeur = largeur;
    }

    public override double GetSurface()
    {
        return Longueur * Largeur;
    }

    public override double GetPerimetre()
    {
        return (Longueur + Largeur) * 2;
    }

    public override string? ToString()
    {
        return $"Rectangle ayant pour origine = ({Origine.X};{Origine.Y}) : Longueur= {Longueur} / Largeur = {Largeur}";

    }

    public override bool Equals(object? obj)
    {
        return obj is Rectangle rectangle &&
               EqualityComparer<Point>.Default.Equals(Origine, rectangle.Origine) &&
               Longueur == rectangle.Longueur &&
               Largeur == rectangle.Largeur;
    }
}
