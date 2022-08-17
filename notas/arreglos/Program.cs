namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vector
            double[] numeros = new double[5] { 2, 2, 2, 2, 2 };
            numeros[1] = 32;

            // Indexando el vector
            System.Console.WriteLine(numeros[1]);
            System.Console.WriteLine(numeros[0]);

            // Lista de strings
            string[] nombres = new string[] { "Capo", "Animal", "Número 1", "Tifón", "Huracán" };

            // Longitud de un vector
            int f;
            f = nombres.Length;
            System.Console.WriteLine(f);

            // Vector definido por el usuario
            System.Console.Write("Ingrese el tamaño del vector que desea llenar: ");
            int length;
            length = Convert.ToInt16(Console.ReadLine());
            double[] userVec = new double[length];

            for (int i = 0; i < length; i++)
            {
                System.Console.Write("Ingrese el valor de la posición " + i + " del vector: ");
                userVec[i] = Convert.ToInt16(Console.ReadLine());

            }

            // Vectores "multidimensionales"
            string[,] names = new string[,] { { "Hola", "mi", "estimado" }, { "Qué", "se", "dice" } }; // Todas las dimensiones deben tener el mismo tamaño
            // Imprimir una posición del arreglo:
            System.Console.WriteLine("El nombre 1 es: " + names[1, 1]);

            int x, y;
            System.Console.Write("x = ");
            x = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("y = ");
            y = Convert.ToInt16(Console.ReadLine());

            double[,] userMatrix = new double[x, y];
        }
    }
}
