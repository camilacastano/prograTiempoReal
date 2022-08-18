namespace cuartoTaller1
{
    class Program
    {
        static int factorial(int num)
        {
            int answer = 1;
            for (int i = 1; i <= num; i++)
            {
                answer = i * answer;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            int n;
            double x, suma = 0;
            System.Console.Write("Ingrese la cantidad de iteraciones que desea: ");
            n = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Ingrese el valor de x a evaluar en la exponencial: ");
            x = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                suma = suma + (Math.Pow(x, i) / factorial(i));
                System.Console.WriteLine("suma=" + suma + ",i=" + i);
            }
            System.Console.WriteLine("La aproximación con " + n + " iteraciones es: " + suma);
        }
    }
}
