using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    class Program
    {
        public static int b1 = 100, b2 = 100, b3 = 100, b4 = 100, b5 = 100, b6 = 100, b7 = 100, b8 = 100; //Cantidad de bebidas de cada tipo
        public static int Billetes1 = 100, Billetes5 = 100; // Cantidad global de billetes
        public static int monedas10 = 100, monedas05 = 100, monedas25 = 100, monedas1 = 100; //Cantidad global de monedas
        public static int res1, opc1, res2;
        public static double sodaadmn = 0.00, téadmn = 0.00, aguaadmn = 0.00;
        public static int refil1 = 0, refil2 = 0, refil3 = 0, refil4 = 0, refil5 = 0, refil6 = 0, refil7 = 0, refil8 = 0;
        public static double p1, p2, p3;

        public static double Monto(double MontoFinal)
        {

            double Monto;
            Monto = MontoFinal;
            return Monto;


        }

        public static double sumar(double billetes, double monto = 0, double Monto = 0)
        {
            return Monto = Monto + billetes;


        }




        public static void Main(string[] args)
        {
            int modo, admn; //Opciones de modo
            int opcionM, opcionB; // Opciones para los bancos de monedas y billetes
            string valida = "maquina123", clave; // Clave de acceso
            Console.WriteLine("Ingrese el modo a utilizar");
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Now;
            int opc, num = 0, billetes = 0;
            double monedas05 = 0, monedas01 = 0, monedas25 = 0, monedas1 = 0, monto = 0;
            double m5 = 0, m10 = 0, m25 = 0;
            int bebida = 0;
            double soda = 0.50, té = 0.60, agua = 1.00, cambio = 0.00;
            Console.WriteLine(" [1] Modo administración");
            Console.WriteLine(" [2] Modo venta");
            modo = Convert.ToInt32(Console.ReadLine());


            AbonoMonedas object1 = new AbonoMonedas();
            DescargaMonedas object2 = new DescargaMonedas();
            ReseteoMonedas object3 = new ReseteoMonedas();
            DescargaBilletes object4 = new DescargaBilletes();
            ReseteoBilletes object5 = new ReseteoBilletes();

            switch (modo)
            {
                case 1:
                    Console.WriteLine("Bienvenido al modo administrador");
                    do
                    {
                        Console.WriteLine("Ingrese su clave de acceso");
                        clave = Console.ReadLine();
                        if (clave != valida)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Clave incorrecta");
                            Console.WriteLine();
                        }

                    } while (clave != valida);


                    Console.WriteLine("");
                    Console.WriteLine("Clave ingresada correctamente");
                    Console.WriteLine("");
                    Console.WriteLine(" [1] Administrar bebidas");
                    Console.WriteLine(" [2] Administrar banco de monedas");
                    Console.WriteLine(" [3] Administrar banco de billetes");
                    Console.WriteLine(" [4] Detalles de la máquina");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Ingrese la opción de la acción a realizar");
                    admn = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (admn)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("         Administrar bebidas    ");
                            Console.WriteLine(" (1). Establecer precios de bebdidas. ");
                            Console.WriteLine(" (2). Establecer cantidad de bebidas. ");
                            Console.WriteLine("---------------------------------------");
                            opc1 = Convert.ToInt32(Console.ReadLine());



                            if (opc1 == 1)
                            {
                                Console.Clear();
                                Console.Write("   ¿Desea modificar los precios de las bebidas? ");
                                Console.WriteLine(" (1). Si");
                                Console.WriteLine(" (2). No");
                                res1 = Convert.ToInt32(Console.ReadLine());

                                switch (res1)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine(" 1. Sodas............ $0.50");
                                        Console.WriteLine(" Ingrese el nuevo precio de las sodas: ");
                                        Console.WriteLine("--------------------------------------");
                                        soda = Convert.ToDouble(Console.ReadLine());
                                        p1 = soda;

                                        Console.WriteLine(" 2. Agua.............. $1.00");
                                        Console.WriteLine(" Ingrese el nuevo precio del agua: ");
                                        Console.WriteLine("--------------------------------------");
                                        agua = Convert.ToDouble(Console.ReadLine());
                                        p2 = agua;

                                        Console.WriteLine(" 3. Té................ $0.60");
                                        Console.WriteLine(" Ingrese el nuevo precio de los tés: ");
                                        Console.WriteLine("--------------------------------------");
                                        té = Convert.ToDouble(Console.ReadLine());
                                        p3 = té;

                                        Console.Clear();
                                        Console.WriteLine("Los nuevos precios de las bebidas son: ");
                                        Console.WriteLine(" 1. Coca-Cola.......... ${0}", p1.ToString("C2"));
                                        Console.WriteLine(" 2. Fanta.............. ${0}", p1.ToString("C2"));
                                        Console.WriteLine(" 3. Agua............... ${0}", p2.ToString("C2"));
                                        Console.WriteLine(" 4. Té de Durazno...... ${0}", p3.ToString("C2"));
                                        Console.WriteLine(" 5. Té de Limón........ ${0}", p3.ToString("C2"));
                                        Console.WriteLine(" 6. Uva................ ${0}", p1.ToString("C2"));
                                        Console.WriteLine(" 7. Sprite............. ${0}", p1.ToString("C2"));
                                        Console.WriteLine(" 8. Crema Soda......... ${0}", p1.ToString("C2"));

                                        Console.WriteLine("Presione <enter> para salir.");
                                        Console.ReadKey();

                                        break;



                                    case 2:

                                        Console.WriteLine(" Los precios de las bebidas son los siguientes: ");
                                        Console.WriteLine(" 1. Coca-Cola.......... $0.50");
                                        Console.WriteLine(" 2. Fanta.............. $0.50");
                                        Console.WriteLine(" 3. Agua............... $1.00");
                                        Console.WriteLine(" 4. Té de Durazno...... $0.60");
                                        Console.WriteLine(" 5. Té de Limón........ $0.60");
                                        Console.WriteLine(" 6. Uva................ $0.50");
                                        Console.WriteLine(" 7. Sprite............. $0.50");
                                        Console.WriteLine(" 8. Crema Soda......... $0.50");

                                        break;

                                }

                            }

                            if (opc1 == 2)
                            {
                                Console.Clear();
                                Console.Write("   ¿Desea modificar las cantidades de las bebidas? ");
                                Console.WriteLine(" (1). Si");
                                Console.WriteLine(" (2). No");
                                res2 = Convert.ToInt32(Console.ReadLine());


                                switch (res2)
                                {
                                    case 1:

                                        Console.WriteLine(" La capacidad de las bebidas son los siguientes: ");
                                        Console.WriteLine(" 1. Coca-Cola.......... 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil1 = Convert.ToInt32(Console.ReadLine());
                                        b1 = b1 + refil1;


                                        Console.WriteLine(" 2. Fanta.............. 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil2 = Convert.ToInt32(Console.ReadLine());
                                        b2 = b2 + refil2;

                                        Console.WriteLine(" 3. Agua............... 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil3 = Convert.ToInt32(Console.ReadLine());
                                        b3 = b3 + refil3;



                                        Console.WriteLine(" 4. Té de Durazno...... 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil4 = Convert.ToInt32(Console.ReadLine());
                                        b4 = b4 + refil4;

                                        Console.WriteLine(" 5. Té de Limón........ 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil5 = Convert.ToInt32(Console.ReadLine());
                                        b5 = b5 + refil5;


                                        Console.WriteLine(" 6. Uva................ 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil6 = Convert.ToInt32(Console.ReadLine());
                                        b6 = b6 + refil6;

                                        Console.WriteLine(" 7. Sprite............. 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil7 = Convert.ToInt32(Console.ReadLine());
                                        b7 = b7 + refil7;

                                        Console.WriteLine(" 8. Crema Soda......... 100 unidades");
                                        Console.WriteLine(" Ingrese la cantidad de la bebida que desea agregar: ");
                                        Console.WriteLine("--------------------------------------");
                                        refil8 = Convert.ToInt32(Console.ReadLine());
                                        b8 = b8 + refil8;


                                        Console.Clear();
                                        Console.WriteLine("Las nuevas cantidades de las bebidas son: ");
                                        Console.WriteLine(" 1. Coca-Cola.......... {0}", b1);
                                        Console.WriteLine(" 2. Fanta.............. {0}", b2);
                                        Console.WriteLine(" 3. Agua............... {0}", b3);
                                        Console.WriteLine(" 4. Té de Durazno...... {0}", b4);
                                        Console.WriteLine(" 5. Té de Limón........ {0}", b5);
                                        Console.WriteLine(" 6. Uva................ {0}", b6);
                                        Console.WriteLine(" 7. Sprite............. {0}", b7);
                                        Console.WriteLine(" 8. Crema Soda......... {0}", b8);

                                        Console.WriteLine("Presione <enter> para salir.");
                                        Console.ReadKey();




                                        break;
                                }
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Administrar banco de monedas");
                            Console.WriteLine(" [1] Abonar");
                            Console.WriteLine(" [2] Descargarr");
                            Console.WriteLine(" [3] Resetear");
                            opcionM = Convert.ToInt32(Console.ReadLine());
                            switch (opcionM)
                            {
                                case 1:
                                    object1.AbonoM();
                                    break;
                                case 2:
                                    object2.DescargaM();
                                    break;
                                case 3:
                                    object3.ReseteoM();
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Administar banco de billetes");
                            Console.WriteLine(" [2] Descargarr");
                            Console.WriteLine(" [3] Resetear");
                            opcionB = Convert.ToInt32(Console.ReadLine());

                            switch (opcionB)
                            {
                                case 1:
                                    object4.DescargaB();
                                    break;
                                case 2:
                                    object5.ReseteoB();
                                    break;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Detalles de la maquina");
                            Console.WriteLine("Fecha: {0} {1} de {2} del {3}", fecha.ToString("dddd"), fecha.Day, fecha.ToString("MMM"), fecha.Year);
                            Console.WriteLine("Hora : {0} ", hora.ToString("hh:mm"));
                            Console.WriteLine("");
                            Console.WriteLine("------------Cantidad de bebidas---------");
                            Console.WriteLine(" 1. Coca-Cola.......... {0}", b1);
                            Console.WriteLine(" 2. Fanta.............. {0}", b2);
                            Console.WriteLine(" 3. Agua............... {0}", b3);
                            Console.WriteLine(" 4. Té de Durazno...... {0}", b4);
                            Console.WriteLine(" 5. Té de Limón........ {0}", b5);
                            Console.WriteLine(" 6. Uva................ {0}", b6);
                            Console.WriteLine(" 7. Sprite............. {0}", b7);
                            Console.WriteLine(" 8. Crema Soda......... {0}", b8);
                            Console.WriteLine("");
                            Console.WriteLine("---------Cantidad de monedas-----------------");
                            Console.WriteLine("Monedas de 10 centavos : {0}", monedas10);
                            Console.WriteLine("Monedas de 5 centavos : {0}", monedas05);
                            Console.WriteLine("Monedas de 25 centavos : {0}", monedas25);
                            Console.WriteLine("Monedas de un dólar : {0}", monedas1);
                            Console.WriteLine("");
                            Console.WriteLine("------Cantidad de billetes----------");
                            Console.WriteLine("Billetes de un dólar : {0}", Billetes1);
                            Console.WriteLine("Billetes de 5 dólares : {0}", Billetes5);
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" 1. Ingresar billetes ");
                    Console.WriteLine(" 2. Ingresar monedas");
                    Console.WriteLine("------------------------------");
                    if (!int.TryParse(Console.ReadLine(), out opc) || (opc == 1 || opc == 2))

                    {
                        if (opc == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" Ingrese su billete: ($1 ó $5) ");
                            billetes = Convert.ToInt32(Console.ReadLine());

                            sumar(monto, billetes);
                            monto = monto + billetes;



                        }

                        else if (opc == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1. ¿Cuantas monedas de $0.05 desea agregar? ");
                            monedas05 = Convert.ToInt32(Console.ReadLine());
                            monedas05 = monedas05 * 0.05;
                            monto = monto + monedas05;


                            Console.WriteLine(" 2. ¿Cuantas monedas de $0.10 desea agregar?");
                            monedas01 = Convert.ToInt32(Console.ReadLine());
                            monedas01 = monedas01 * 0.10;
                            monto = monto + monedas01;


                            Console.WriteLine(" 3. ¿Cuantas monedas de $0.25 desea agregar?");
                            monedas25 = Convert.ToInt32(Console.ReadLine());
                            monedas25 = monedas25 * 0.25;
                            monto = monto + monedas25;

                            Console.WriteLine(" 4. ¿Cuantas monedas de $1? desea agregar ");
                            monedas1 = Convert.ToInt32(Console.ReadLine());
                            monedas1 = monedas1 * 1.00;
                            monto = monto + monedas1;

                        }


                    }

                    Console.Clear();
                    Console.WriteLine("La cantidad de dinero ingresada es de:${0} ", monto.ToString("C2"));
                    Console.WriteLine("------------------------------");

                    Console.WriteLine("--------Menu de Sodas--------");
                    Console.WriteLine(" [1] Coca-Cola.......... $0.50");
                    Console.WriteLine(" [2] Fanta.............. $0.50");
                    Console.WriteLine(" [3] Agua............... $1.00");
                    Console.WriteLine(" [4] Té de Durazno...... $0.60");
                    Console.WriteLine(" [5] Té de Limón........ $0.60");
                    Console.WriteLine(" [6] Uva................ $0.50");
                    Console.WriteLine(" [7] Sprite............. $0.50");
                    Console.WriteLine(" [8] Crema Soda......... $0.50");
                    Console.WriteLine("------------------------------");

                    bebida = Convert.ToInt32(Console.ReadLine());





                    switch (bebida)

                    {
                        case 1:
                        case 2:
                        case 6:
                        case 7:
                        case 8:

                            if (monto > soda)
                            {
                                cambio = monto - soda;
                                Console.Clear();
                                Console.WriteLine("Su cambio es:${0}", cambio.ToString("C2"));
                                Console.WriteLine("Que disfrute su bebida");
                                Console.ReadKey();

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Que disfrute su bebida");
                                Console.ReadKey();
                            }


                            if (monto < soda)
                            {
                                Console.Clear();
                                Console.WriteLine(" La cantidad de dinero ingresada no es suficiente.");
                                Console.WriteLine(" ¿Desea ingresar el dinero faltante?");
                                Console.WriteLine("  [1]. Si");
                                Console.WriteLine("  [2]. No");
                                Console.WriteLine("------------------");
                                num = Convert.ToInt32(Console.ReadLine());

                                switch (num)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("La cantidad de dinero ingresada es de:${0} ", monto.ToString("C2"));
                                        Console.WriteLine("------------------------------");

                                        Console.WriteLine(" 1. ¿Cuantas monedas de $0.05 desea agregar? ");
                                        m5 = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine(" 2. ¿Cuantas monedas de $0.10 desea agregar?");
                                        m10 = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine(" 3. ¿Cuantas monedas de $0.25 desea agregar?");
                                        m25 = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();
                                        Console.WriteLine("Que disfrute su bebida ");
                                        Console.ReadKey();
                                        break;

                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Su dinero:${0} ", monto.ToString("C2"));
                                        Console.WriteLine("Presione <enter> pasar salir. ");
                                        Console.ReadKey();
                                        break;



                                }

                            }
                            break;





                        case 3:


                            if (monto > agua)
                            {
                                cambio = monto - agua;
                                Console.Clear();
                                Console.WriteLine("Su cambio es:${0}", cambio.ToString("C2"));
                                Console.WriteLine("Que disfrute su bebida");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Que disfrute su bebida");
                                Console.ReadKey();
                            }

                            if (monto < agua)
                            {
                                Console.Clear();
                                Console.WriteLine(" La cantidad de dinero ingresada no es suficiente.");
                                Console.WriteLine("  ¿Desea ingresar el dinero faltante?");
                                Console.WriteLine("  [1]. Si");
                                Console.WriteLine("  [2]. No");
                                Console.WriteLine("------------------");
                                num = Convert.ToInt32(Console.ReadLine());

                                switch (num)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("La cantidad de dinero ingresada es de:${0} ", monto.ToString("C2"));
                                        Console.WriteLine("------------------------------");

                                        Console.WriteLine(" 1. ¿Cuantas monedas de $0.05 desea agregar? ");
                                        m5 = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine(" 2. ¿Cuantas monedas de $0.10 desea agregar?");
                                        m10 = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine(" 3. ¿Cuantas monedas de $0.25 desea agregar?");
                                        m25 = Convert.ToInt32(Console.ReadLine());

                                        Console.Clear();
                                        Console.WriteLine("Que disfrute su bebida");
                                        Console.ReadKey();
                                        break;


                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Su dinero:${0} ", monto.ToString("C2"));
                                        Console.WriteLine("Presione <enter> pasar salir. ");
                                        Console.ReadKey();


                                        break;
                                }

                            }

                            break;


                        case 4:
                        case 5:


                            if (monto > té)
                            {
                                cambio = monto - té;
                                Console.Clear();
                                Console.WriteLine("Su cambio es:${0}", cambio.ToString("C2"));
                                Console.WriteLine("Que disfrute su bebida");
                                Console.ReadKey();
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Que disfrute su bebida");
                                Console.ReadKey();
                            }


                            if (monto < té)
                            {
                                Console.Clear();
                                Console.WriteLine(" La cantidad de dinero ingresada no es suficiente.");
                                Console.WriteLine("  ¿Desea ingresar el dinero faltante?");
                                Console.WriteLine("  [1]. Si");
                                Console.WriteLine("  [2]. No");
                                Console.WriteLine("------------------");
                                num = Convert.ToInt32(Console.ReadLine());

                                switch (num)
                                {
                                    case 1:

                                        Console.Clear();
                                        Console.WriteLine("La cantidad de dinero ingresada es de:${0} ", monto.ToString("C2"));
                                        Console.WriteLine("------------------------------");

                                        Console.WriteLine(" 1. ¿Cuantas monedas de $0.05 desea agregar? ");
                                        m5 = Convert.ToInt32(Console.ReadLine());


                                        Console.WriteLine(" 2. ¿Cuantas monedas de $0.10 desea agregar?");
                                        m10 = Convert.ToInt32(Console.ReadLine());


                                        Console.WriteLine(" 3. ¿Cuantas monedas de $0.25 desea agregar?");
                                        m25 = Convert.ToInt32(Console.ReadLine());


                                        Console.Clear();
                                        Console.WriteLine("Que disfrute su bebida");
                                        Console.ReadKey();
                                        break;


                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("Su dinero:${0} ", monto.ToString("C2"));
                                        Console.WriteLine("Presione <enter> pasar salir. ");
                                        Console.ReadKey();


                                        break;

                                }

                            }
                            break;


                    }
                    break;

            }
        }
    }
}