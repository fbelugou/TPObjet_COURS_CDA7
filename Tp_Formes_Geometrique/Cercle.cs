// See https://aka.ms/new-console-template for more information
using Tp_Formes_Geometrique;

internal class Cercle : Forme
{
    public double Rayon { get; private set; }

    public Cercle(double rayon, Point centre) : base(centre)
    {
        Rayon = rayon;
    }

    public override double GetSurface()
    {
        return Rayon * Math.PI;
    }

    public override double GetPerimetre()
    {
        return Math.PI * Math.Pow(Rayon, 2);
    }

    public override string? ToString()
    {
        return $"Cercle ayant pour centre = ({Origine.X};{Origine.Y}) : Rayon={Rayon}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Cercle cercle &&
               EqualityComparer<Point>.Default.Equals(Origine, cercle.Origine) &&
               Rayon == cercle.Rayon;
    }
}