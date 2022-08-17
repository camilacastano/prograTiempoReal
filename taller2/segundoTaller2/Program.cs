int n, interval, tamInterval, cont = 0;

System.Console.Clear();
System.Console.Write("Ingrese el tamaño del histograma: ");
n = Convert.ToInt16(System.Console.ReadLine());
System.Console.WriteLine();
double[] data = new double[n];

for (int i = 0; i < data.Length; i++)
{
    System.Console.Write("Ingrese el dato " + (i + 1) + " del histograma: ");
    data[i] = Convert.ToDouble(Console.ReadLine());
}

System.Console.Write("\nIngrese el número de intervalos que desea para el histograma: ");
interval = Convert.ToInt16(Console.ReadLine());
double[] hist = new double[interval];

tamInterval = Convert.ToInt16((data.Max() - data.Min()) / interval);

System.Console.WriteLine("Tamaño del intervalo: " + tamInterval);

for (int i = Convert.ToInt16(data.Min()); i <= data.Max(); i += tamInterval)
{
    for (int k = 0; k < data.Length; k++)
    {
        if ((data[k] >= i) && (data[k] < (i + tamInterval)))
        {
            hist[cont] = hist[cont] + 1;
        }
    }
    cont++;
}

interval = Convert.ToInt16(data.Min());
for (int i = 0; i < hist.Length; i++)
{
    for (int j = 0; j < hist[i]; j++) { System.Console.Write("🧊"); }
    System.Console.WriteLine(" | -> (" + interval + ", " + (interval + tamInterval) + ")");
    interval = interval + tamInterval;
}

