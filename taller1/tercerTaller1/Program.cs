using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejer3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            double infLim = 0, uppLim = 0, sumaPar = 0, sumaImpar = 0, promImpar = 0, promPar = 0;

            while (true)
            {
                Console.Clear();
                System.Console.WriteLine("\t\t👋 Bienvenido");
                System.Console.WriteLine("Elija una de las siguientes opciones:");
                System.Console.WriteLine("1) Límite inferior: " + infLim + " \n2) Límite superior: " + uppLim + "\n3) Determinar suma y promedio de los pares e impares del intervalo\n4) Salir");
                System.Console.Write("\nOpción: ");
                opt = Convert.ToInt16(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        System.Console.Write("Ingrese el límite inferior: ");
                        infLim = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 2:
                        System.Console.Write("Ingrese el límite superior: ");
                        uppLim = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 3:
                        int npares = 0, nimpar = 0;
                        if (infLim < uppLim)
                        {
                            for (int i = Convert.ToInt16(infLim); i <= Convert.ToInt16(uppLim); i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sumaPar = sumaPar + i;
                                    npares++;
                                }
                                else
                                {
                                    sumaImpar = sumaImpar + i;
                                    nimpar++;
                                }

                            }
                            promPar = sumaPar / npares;
                            promImpar = sumaImpar / nimpar;

                            System.Console.WriteLine("EL promedio de los pares es " + promPar);
                            System.Console.WriteLine("El promedio de los impares es " + promImpar);
                            System.Console.ReadKey();
                        }
                        else
                        {
                            System.Console.WriteLine("EL límite inferior es mayor al superior");
                        }

                        break;

                    case 4:
                        break;

                    default:
                        System.Console.WriteLine("La opción ingresada no existe");
                        System.Console.ReadKey();
                        break;

                }
                if (opt == 4)
                {
                    break;
                }
            }
        }
    }
}
s
