using LegoLand.Legos.Heads;
using LegoLand.Legos.Torsos;
using System;
using LegoLand.Legos;
using LegoLand.Legos.Legs;

namespace LegoLand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Lego Land.");

            var myDogHead = new Dog();
            var martinHead = new Bald();
            var astronaut = new Astronaut();

            var fitTorso = new FitTorso(2, Sex.Male, Colors.Freckles);
            fitTorso.Crunch(12);

            var adamsLegs = new OrangeLegs(Length.Short);

            var minifigure = new Minifigure("Adam", astronaut, fitTorso, adamsLegs);

            minifigure.Greet();


            Console.ReadLine();

        }
    }
}
