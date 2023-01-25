using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Point;

namespace TP_Cercle;
/// <summary>
/// Représente un cercle
/// </summary>
internal class Cercle
{

    /// <summary>
    /// Centre du cercle
    /// </summary>
    public Point Centre {get; private set;}

    /// <summary>
    /// Rayon du cercle
    /// </summary>
    public double Rayon {get; private set;}

    /// <summary>
    /// Constructeur
    /// </summary>
    public Cercle()
    {
        double  abscisse;
        double  ordonne;
        Console.WriteLine("Donner l'abscisse du centre :");
        abscisse = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Donner l'ordonnée du centre :");
        ordonne = double.Parse(Console.ReadLine());

        Centre = new Point(abscisse, ordonne);
        
        Console.WriteLine("Donner le rayon du cercle :");
        Rayon = double.Parse(Console.ReadLine());
    }

    /// <summary>
    /// Constructeur du cercle avec rayon et origine
    /// </summary>
    /// <param name="centre">Origine du cercle</param>
    /// <param name="rayon">Rayon du cercle</param>
    public Cercle(Point centre, double rayon)
    {
        Centre = centre;
        Rayon = rayon;
    }


    /// <summary>
    /// PErmet de calculer le périmètre
    /// </summary>
    /// <returns>Retourne le périmètre du cercle</returns>
    public double GetPerimetre()
    {
        return Math.PI * Rayon;
    }

    /// <summary>
    /// PErmet de calculer la surface du cercle
    /// </summary>
    /// <returns>Retourne la surface du cercle</returns>
    public double GetSurface()
    {
        return Math.PI * Math.Pow(Rayon, 2);
    }

    /// <summary>
    /// Permet de savoir si un point appartient au cercle
    /// </summary>
    /// <param name="searchPoint">Point à rechercher</param>
    /// <returns>Retourne si le point appartient au cercle</returns>
    public bool Appartient(Point searchPoint)
    {
        double distanceAbscisse = Math.Sqrt(
            Math.Pow((searchPoint.Abscisse - Centre.Abscisse ), 2)); 

        double distanceOrdonee = Math.Sqrt(
            Math.Pow((searchPoint.Ordonne - Centre.Ordonne ), 2)); 
        
        return distanceAbscisse <= Rayon && distanceOrdonee <= Rayon;
    }

    /// <summary>
    /// Affiche les informations du cercle
    /// </summary>
    public void Afficher()
    {
        Console.WriteLine($"CERCLE({Centre.Abscisse},{Centre.Ordonne},{Rayon})");
        Console.WriteLine($"Le périmètre du cercle est de : {Math.Round(GetPerimetre(),2)} cm");
        Console.WriteLine($"La surface du cercle est de : {Math.Round(GetSurface(), 2)} cm²");
   
     }
}
