namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int[] wagons = new int[n];
            for (int i = 0; i < n; i++)
            {
                int NumAdd = int.Parse(Console.ReadLine());
                wagons[i] = NumAdd;
                count += wagons[i];
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(count);
        }
    }
}
