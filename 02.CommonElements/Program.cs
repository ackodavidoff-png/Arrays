namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Масив 1
            //Масив 2
            string[] FirstArray = Console.ReadLine().Split().ToArray();
            string[] SecondArray = Console.ReadLine().Split().ToArray();
            bool IsCommon = false;
            for (int i = 0; i < SecondArray.Length; i++)
            {
                for (int j = 0; j < FirstArray.Length; j++)
                {
                    IsCommon = FirstArray[j] == SecondArray[i];
                    if (IsCommon)
                    {
                        Console.Write($"{FirstArray[j]} ");
                    }
                }
            }
        }
    }
}
