namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] FirstArray = new int[n];
            int[] SeccondArray = new int[n];
            bool IsFirstSelected = true;
            for (int i = 0; i < n; i++)
            {
                int[] Array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (IsFirstSelected)
                {
                    FirstArray[i] = Array[0];
                    SeccondArray[i] = Array[1];
                }
                else
                {
                    FirstArray[i] = Array[1];
                    SeccondArray[i] = Array[0];
                }
                IsFirstSelected = !IsFirstSelected;
            }
            Console.WriteLine(String.Join(" ", FirstArray));
            Console.WriteLine(String.Join(" ", SeccondArray));
        }
    }
}
