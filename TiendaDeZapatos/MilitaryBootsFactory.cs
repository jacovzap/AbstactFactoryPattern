using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaBotas
{
    class MilitaryBootsFactory: AbstractBootsFactory
    {
        public Boots CreateBoots(string Color, decimal Price, int Size)
        {
            MilitaryBoots NewMilitaryBoots = new MilitaryBoots(Color,Price,Size);
            return NewMilitaryBoots;
        }
    }
}
