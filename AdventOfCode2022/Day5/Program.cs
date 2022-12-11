using InputReader;

namespace AdventOfCode2022.Day5;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = InputProvider.GetStringInput(ExerciseIds.Day5);

        var ex1Result = Exercise1.Solve(input);
        Console.WriteLine($"Exercise 1 result: {ex1Result}");
    }
}
