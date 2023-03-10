namespace BubbleSort;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 3, 4 , 2, 1, 10, 6, 7, 9, 8 };

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                var tmpNumber = numbers[j + 1];
                if (numbers[j] > numbers[j + 1])
                {
                    numbers[j + 1] = numbers[j];
                    numbers[j] = tmpNumber;
                }
            }
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number.ToString());
        }
    }
}
