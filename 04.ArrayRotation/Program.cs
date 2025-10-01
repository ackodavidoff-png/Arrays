namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < Rotations; i++)
            {
                int FirstElement = Array[0];
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    Array[j] = Array[j + 1];
                }
                Array[Array.Length - 1] = FirstElement;
            }
            Console.WriteLine(String.Join(" ", Array));
        }
    }
}
