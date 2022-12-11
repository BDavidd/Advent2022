using InputReader;

namespace AdventOfCode2022.Day2;

internal class Program
{
    private static void Main(string[] args)
    {
        var exercise1Input = InputProvider.GetStringInput(ExerciseIds.Exercise1Day2);
        var ex1Result = Exercise1.Solve(exercise1Input);
        Console.WriteLine($"Exercise 1 result: {ex1Result}");

        var exercise2Input = InputProvider.GetStringInput(ExerciseIds.Exercise2Day2);
        var ex2Result = Exercise2.Solve(exercise2Input);
        Console.WriteLine($"Exercise 2 result: {ex2Result}");
    }
}