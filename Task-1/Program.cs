internal class Program
{
    private static void Main(string[] args)
    {
        double[] array = new double[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = random();
        }

        static double random()
        {
            Random rnd = new Random();
            double rand = rnd.Next(-99999, 99999);
            return rand / 100;
        }

        double cpsn;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    cpsn = array[i];
                    array[i] = array[j];
                    array[j] = cpsn;
                }
            }
        }
        Console.WriteLine($@"Максимальное число:
{Convert.ToString(array[array.Length - 1])}");
        Console.WriteLine($@"Минимальное число:
{Convert.ToString(array[0])}");
       
    }
}