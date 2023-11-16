namespace _02._Sum_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

            int sum = 0;

            for (int index = 0; index <= numbers.Length - 1; index++)
            {
                sum += numbers[index];

            }
            Console.WriteLine(sum);
        }
    }
}

