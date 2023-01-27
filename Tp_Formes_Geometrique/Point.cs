namespace Tp_Formes_Geometrique;

internal class Point
{
    public double X { get; private set; }

    public double Y { get; private set; }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point(Point otherPoint) 
        : this(otherPoint.X, otherPoint.Y) { }


    public void DeplacementDeX(double deltaX)
    {
        X += deltaX;
    }

    public void DeplacementDeY(double deltaY)
    {
        Y += deltaY;
    }


    public void Deplacement(double deltaX, double deltaY) { DeplacementDeX(deltaX); DeplacementDeY(deltaY); }

    public double Distance(Point autrePoint)
    {
        return Math.Sqrt(
            Math.Pow(autrePoint.X - X, 2)
            +
            Math.Pow(autrePoint.Y - Y, 2)
            );
    }

    public override bool Equals(object? obj)
    {
        return obj is Point point &&
               X == point.X &&
               Y == point.Y;
    }

    public override string? ToString()
    {
        return $"({X} ; {Y})";
    }
}