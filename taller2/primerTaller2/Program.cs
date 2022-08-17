using System;

public class Program
{
    public static void Main(string[] args)
    {
        int col, col1;
        int fil, fil1;
        int opcion;

        //double[,] matrizb = new double[fil1, col1];

        Console.Write("Ingrese numero de filas de la primer matriz:  ");
        fil = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ingrese el numero de columnas de la primer matriz:");
        col = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

        Console.Write("Ingrese numero de filas de la segunda matriz:  ");
        fil1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Ingrese el numero de columnas de la segunda matriz :");
        col1 = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

        double[,] matrizA = new double[fil, col];
        for (int i = 0; i < fil; i++)
        {
            for (int j = 0; j < col; j++)
            {

                Console.WriteLine("Ingrese el dato: " + "[" + (i + 1) + " " + (j + 1) + "]" + " de la primer matriz");

                matrizA[i, j] = Convert.ToInt16(Console.ReadLine());
            }

        }

        Console.Clear();


        double[,] matrizB = new double[fil1, col1];
        for (int i1 = 0; i1 < fil1; i1++)
        {
            for (int j1 = 0; j1 < col1; j1++)
            {
                Console.WriteLine("Ingrese el dato " + "[" + (i1 + 1) + " " + (j1 + 1) + "]" + " de la segunda matriz");

                matrizB[i1, j1] = Convert.ToInt16(Console.ReadLine());
            }

        }

        Console.Clear();

        do
        {



            Console.WriteLine("***********************************************");

            Console.WriteLine("1. Sumar matrices ");
            Console.WriteLine("2. Restar matrices ");
            Console.WriteLine("3. Multiplicacion de matrices");
            Console.WriteLine("4. Multiplicar x matriz por un escalar ");
            Console.WriteLine("***********************************************");


            Console.Write("Seleccione Opcion :");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    if ((fil == fil1) && (col == col1))
                    {

                        double[,] matrizC = new double[fil, col];
                        for (int i = 0; i < fil; i++)
                        {
                            for (int j = 0; j < col; j++)

                            {
                                matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                                Console.Write(matrizC[i, j]);
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("No se puede realizar la operación");
                    }



                    break;


                case 2:

                    if ((fil == fil1) && (col == col1))
                    {
                        double[,] matrizD = new double[fil, col];
                        for (int i = 0; i < fil; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                matrizD[i, j] = matrizA[i, j] - matrizB[i, j];
                                Console.Write(matrizD[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }

                    break;

                case 3:

                    if (col == fil1)
                    {
                        double[,] matrizE = new double[fil, col1];
                        for (int i = 0; i < fil1; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                matrizE[i, j] = 0;
                                for (int z = 0; z < col1; z++)
                                {
                                    matrizE[i, j] = matrizA[i, z] * matrizB[z, j] + matrizE[i, j];
                                }
                            }
                        }

                        for (int i1 = 0; i1 < fil; i1++)
                        {
                            for (int j1 = 0; j1 < col1; j1++)
                            {
                                Console.Write(matrizE[i1, j1]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pueden multiplicar las matrices");
                    }



                    break;


            }





        } while (opcion != 0);
    }
}

