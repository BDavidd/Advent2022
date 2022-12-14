using System.Text;

namespace AdventOfCode2022.Day5;

internal static class Exercise2
{
    public static string Solve(IReadOnlyCollection<string> input)
    {
        var state = Utils.ReadInitialState(input);

        // First 10 lines are used to describe the initial state.
        foreach (var instruction in input.Skip(10))
        {
            var components = instruction.Split(' ');
            var count = int.Parse(components[1]);
            var from = int.Parse(components[3]);
            var to = int.Parse(components[5]);

            var moved = new Stack<char>();
            for (int i = 0; i < count; i++)
            {
                if (state[from].TryPop(out var takenChar))
                {
                    moved.Push(takenChar);
                }
            }

            while (moved.TryPop(out var taken)) 
            {
                state[to].Push(taken);
            }
        }

        var result = new StringBuilder();
        for (int i = 1; i <= 9; i++)
        {
            var topChar = state[i].Peek();
            if (char.IsLetter(topChar))
            {
                result.Append(topChar);
            }
        }

        return result.ToString();
    }
}
