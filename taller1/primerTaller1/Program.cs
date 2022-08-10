namespace primerTaller1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double suma = 0, number, prom = 0;
            string option = "y";
            while (option == "y")
            {
                System.Console.Write("Ingrese un número: ");
                number = Convert.ToInt16(Console.ReadLine());
                suma = suma + number;
                i++;
                prom = suma / i;

                for (int j = 0; j == 0;)
                {
                    System.Console.Write("¿Quiere ingresar más números? (y/n): ");
                    option = Console.ReadLine();
                    if (option == "y" || option == "n")
                    {
                        break;
                    }
                }
            }
            System.Console.WriteLine("El promedio de los " + i + " números es: " + Convert.ToString(prom));

        }
    }
}
