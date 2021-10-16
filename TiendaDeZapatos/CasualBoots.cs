using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaBotas
{
    class CasualBoots: Boots
    {
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }


        public CasualBoots(string Color, decimal Price, int Size)
        {
            this.Color = Color;
            this.Price = Price;
            this.Size = Size;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"-------------- BOTA CASUAL -----------------");
            Console.WriteLine($"- Color: {Color}");
            Console.WriteLine($"- Tamanio: {Size}");
            Console.WriteLine($"- Precio: {Price}");
        }
    }
}
