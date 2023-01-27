// See https://aka.ms/new-console-template for more information
using Tp_Formes_Geometrique;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Liste des formes géométriques :\n");
Console.ForegroundColor = ConsoleColor.White;

List<Forme> list = new List<Forme>()
{
    new Cercle(1.1d, new Point(1.5d, 5d)),
    new Rectangle(1d, 3d, new Point(3d,6d)),
    new Rectangle(4d, 44d, new Point(3d,6d)),
    new Rectangle(10d, 15.5d, new Point(3d,6d)),
    new Rectangle(16.5d, 22d, new Point(3d,6d)),
    new Cercle(10.1d, new Point(1.5d, 5d)),
    new Cercle(100.99d, new Point(1.5d, 5d)),
    new Cercle(15d, new Point(1.5d, 5d)),
    new Cercle(11d, new Point(1.5d, 5d)),
};
list.ForEach(forme => Console.WriteLine(forme));


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\nListe des formes géométriques triées par surface:\n");
Console.ForegroundColor = ConsoleColor.White;
list.Sort();
list.ForEach(forme => Console.WriteLine($"{forme} => Surface : {forme.GetSurface()}"));