using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> printC(ConsoleColor color, int start, int end)
    {
        int numOfIterations = end - start;

        for (int i = start; i < end; i++)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(i);

            await Task.Delay(100);
        }

        Console.ResetColor();

        return numOfIterations;
    }

    static async Task Main(string[] args)
    {
        Task<int> task1 = printC(ConsoleColor.Red, 1, 10);
        Task<int> task2 = printC(ConsoleColor.Green, 20, 30);

        int result1 = await task1;
        int result2 = await task2;

        Console.WriteLine("Task 1 iterations: " + result1);
        Console.WriteLine("Task 2 iterations: " + result2);
    }
}
