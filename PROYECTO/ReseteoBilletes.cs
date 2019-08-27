using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    class ReseteoBilletes
    {
        public static int Billetes1 = 100, Billetes5 = 100;
        public void ReseteoB()
        {
            Console.Clear();
            Console.WriteLine("Usted ha elegido resetear el banco de monedas");


            Billetes1 = 0;
            Billetes5 = 0;



            Console.WriteLine("La nueva cantidad de billetes de un dólar es: {0}", Billetes1);
            Console.WriteLine("La nueva cantidad de billetes de 5 dólares es: {0}", Billetes5);
            Console.ReadKey();
        }
    }
}
