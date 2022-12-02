using AdventOfCode2022;
using InputReader;

internal class Program
{
    private static void Main(string[] args)
    {
        var exercise1Input = InputProvider.GetInput(ExerciseIds.Exercise1Day1);
        var ex1Result = new Exercise1().Solve(exercise1Input);
        Console.WriteLine(ex1Result);

        exercise1Input.Dispose();
    }
}