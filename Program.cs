namespace Labb7OOP
{                       // Johanna Marklund .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel = new Rektangel();
            Console.WriteLine($"Area rektangel: {rektangel.Area()} cm2");

            Fyrkant fyrkant = new Fyrkant();
            Console.WriteLine($"Area fyrkant: {fyrkant.Area()} cm2");

            Cirkel cirkel = new Cirkel();
            Console.WriteLine($"Area Cirkel: {cirkel.Area()} cm2");

            Parallellogram parallellogram = new Parallellogram();
            Console.WriteLine($"Area parallellogram: {parallellogram.Area()} cm2");

            Ellips ellips = new Ellips();
            Console.WriteLine($"Area ellips: {ellips.Area()} cm2");
        }
    }
}