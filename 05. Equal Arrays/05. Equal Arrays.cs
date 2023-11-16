namespace _05._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNUmber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isIdentical = true;

            for(int index = 0; index <= firstNUmber.Length-1; index++)
            {
                if (firstNUmber[index] != secondNumber[index])
                
                {
                    Console.WriteLine("Arrays are not identical.");
                    break;
                }
            }
        }
    }
}