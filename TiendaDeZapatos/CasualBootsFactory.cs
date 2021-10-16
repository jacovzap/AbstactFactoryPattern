using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaBotas
{
    class CasualBootsFactory: AbstractBootsFactory
    {
        public Boots CreateBoots(string Color, decimal Price, int Size)
        {
            CasualBoots NewCasualBoots = new CasualBoots(Color, Price, Size);
            return NewCasualBoots;
        }
    }
}
