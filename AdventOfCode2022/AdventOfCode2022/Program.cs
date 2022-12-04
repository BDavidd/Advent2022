using AdventOfCode2022;
using InputReader;

internal class Program
{
    private static void Main(string[] args)
    {
        var exercise1Input = InputProvider.GetInput(ExerciseIds.Exercise1Day1);
        var ex1Result = new Exercise1().Solve(exercise1Input);
        Console.WriteLine(ex1Result);

        var exercise2Input = InputProvider.GetInput(ExerciseIds.Exercise2Day1);
        var ex2Result = new Exercise2().Solve(exercise2Input);
        Console.WriteLine(ex2Result);

        exercise1Input.Dispose();
        exercise2Input.Dispose();
    }
}