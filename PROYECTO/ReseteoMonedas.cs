using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    class ReseteoMonedas
    {
        public static int monedas10 = 100, monedas05 = 100, monedas25 = 100, monedas1 = 100;
        public void ReseteoM()
        {
            Console.Clear();
            Console.WriteLine("Usted ha elegido resetear el banco de monedas");
            monedas10 = 0;
            monedas05 = 0;
            monedas25 = 0;
            monedas1 = 0;


            Console.WriteLine("La nueva cantidad de monedas de diez centavos es: {0}", monedas10);
            Console.WriteLine("La nueva cantidad de monedas de 5 centavos es: {0}", monedas05);
            Console.WriteLine("La nueva cantidad de monedas de 25 centavos es: {0}", monedas25);
            Console.WriteLine("La nueva cantidad de monedas de un dólar es: {0}", monedas1);
            Console.ReadKey();
        }
    }
}
