using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    class DescargaBilletes
    {
        public static int Billetes1 = 100, Billetes5 = 100;
        public static int NuevaCB1, NuevaCB5;
        public void DescargaB()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de billetes que desea descargar");
            Console.WriteLine("Para billetes de un dólar");
            NuevaCB1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para billetes de 5 dólares");
            NuevaCB5 = Convert.ToInt32(Console.ReadLine());


            Billetes1 = Billetes1 - NuevaCB1;
            Billetes5 = Billetes5 - NuevaCB5;


            Console.WriteLine("La nueva cantidad de billetes de un dólar es: {0}", Billetes1);
            Console.WriteLine("La nueva cantidad de billetes de 5 dólares es: {0}", Billetes5);

            Console.ReadKey();
        }
    }
}
