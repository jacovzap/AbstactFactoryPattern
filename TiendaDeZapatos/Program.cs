using System;
using System.Collections.Generic;

namespace FabricaBotas
{
    class Program
    {
        static void Main(string[] args)
        {
            //CASO DE USO: 
            //Se desea fabricar media docena de botas para su venta, 3 pares de tipo militar y tres de tipo casual
            //Las botas se enlista en un solo paquete y se envian

            List<Boots> BootsList = new List<Boots>();
            MilitaryBootsFactory MFactory = new MilitaryBootsFactory();
            CasualBootsFactory CFactory = new CasualBootsFactory();

            //Se crea tres pares de botas militar
            BootsList.Add(MFactory.CreateBoots("Negro", 40, 40));
            BootsList.Add(MFactory.CreateBoots("Cafe", 50, 38));
            BootsList.Add(MFactory.CreateBoots("Negro", 45, 41));

            //Se crea tres pares de botas casual
            BootsList.Add(CFactory.CreateBoots("Azul", 40, 40));
            BootsList.Add(CFactory.CreateBoots("Gris", 35, 36));
            BootsList.Add(CFactory.CreateBoots("Beige", 30, 37));


            //Se muestra el contenido del paquete
            foreach (var Boots in BootsList)
            {
                Boots.ShowInformation();
            }
        }
    }
}
