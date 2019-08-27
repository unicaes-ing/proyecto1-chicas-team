using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    class AbonoMonedas
    {
        public static int monedas10 = 100, monedas05 = 100, monedas25 = 100, monedas1 = 100;
        public static int NuevaC01, NuevaC05, NuevaC25, NuevaC1;
        public void AbonoM()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de monedas que desea abonar");
            Console.WriteLine("Para monedas de 10 centavos");
            NuevaC01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para monedas de 5 centavos");
            NuevaC05 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para monedas de 25 centavos");
            NuevaC25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para monedas de un dólar");
            NuevaC1 = Convert.ToInt32(Console.ReadLine());


            monedas10 = monedas10 + NuevaC01;
            monedas05 = monedas05 + NuevaC05;
            monedas25 = monedas25 + NuevaC25;
            monedas1 = monedas1 + NuevaC1;

            Console.WriteLine("La nueva cantidad de monedas de 10 centavos es: {0}", monedas10);
            Console.WriteLine("La nueva cantidad de monedas de 5 centavos es: {0}", monedas05);
            Console.WriteLine("La nueva cantidad de monedas de 25 centavos es: {0}", monedas25);
            Console.WriteLine("La nueva cantidad de monedas de un dólar es: {0}", monedas1);
            Console.ReadKey();
        }
    }
}
