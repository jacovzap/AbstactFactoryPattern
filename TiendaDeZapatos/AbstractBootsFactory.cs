using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaBotas
{
    public interface AbstractBootsFactory
    {
        Boots CreateBoots(string Color, decimal Price, int Size);
    }
}
