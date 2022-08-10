namespace segundoTaller1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = true;
            int firstDigit, secondDigit, number = 0;
            while (error == true)
            {
                System.Console.Write("Ingrese un número de dos cifras: ");
                number = Convert.ToInt16(Console.ReadLine());
                if (number > 10 && number < 100)
                {
                    System.Console.WriteLine("El número tiene dos cifras 💕");
                    error = false;
                }
                else
                {
                    System.Console.WriteLine("Lea bien, el número ingresado no tiene dos cifras");
                    break;
                }
            }
            firstDigit = number % 10;
            secondDigit = number / 10;
        }
    }
}
