using LegoLand.Legos.Heads;
using LegoLand.Legos.Legs;
using LegoLand.Legos.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoLand.Legos
{
    class Minifigure
    {
        public string Name { get; set; }
        public Head Head { get; set; }
        public Torso Body { get; set; }
        public LegsBase Legs { get; set; }

        public Minifigure(string name, Head head, Torso body, LegsBase legs)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
        }

        public void Greet()
        {
            Legs.Walk();
            Head.Talk();
            Body.Wave();
        }

    }
}
