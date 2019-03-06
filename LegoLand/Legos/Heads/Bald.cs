using System;
using System.Collections.Generic;
using System.Text;

namespace LegoLand.Legos.Heads
{
    class Bald : Head
    {
        // Properties //

        public int ShineLevel { get; set; }

        public bool HasToupe { get; set; }

        // Fields //
        // Constructor //

        // Methods //
        public void Cut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;
        }

        public override string Talk()
        {
            return "I pity the foo'!";
        }
    }

    enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }
}