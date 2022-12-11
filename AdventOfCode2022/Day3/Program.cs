using InputReader;

namespace AdventOfCode2022.Day3;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = InputProvider.GetStringInput(ExerciseIds.Day3);

        var ex1Result = Exercise1.Solve(input);
        Console.WriteLine($"Exercise 1 result: {ex1Result}");

        var ex2Result = Exercise2.Solve(input);
        Console.WriteLine($"Exercise 2 result: {ex2Result}");
    }
}