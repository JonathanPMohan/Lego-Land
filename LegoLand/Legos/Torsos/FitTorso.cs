using System;
using System.Collections.Generic;
using System.Text;

namespace LegoLand.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Sex sex, Colors color)
            : base(numberOfArms, sex, color, "OMG, so fit.")
        {
        }


        public void Crunch(int howManyCrunches)
        {
            FitnessOfAbdomen = FitnessOfAbdomen + (" Even more fit.");
            Console.WriteLine($"I just did { howManyCrunches}, brah. Crossfit!!");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("Hi");
        }
    }
}
