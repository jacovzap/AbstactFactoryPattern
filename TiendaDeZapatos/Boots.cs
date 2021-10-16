using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaBotas
{
    public interface Boots
    {
         string Color { get; set; }
         decimal Price { get; set; }
         int Size { get; set; }

         void ShowInformation();
    }
}
