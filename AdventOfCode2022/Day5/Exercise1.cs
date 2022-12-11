using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day5;

internal static class Exercise1
{
    public static string Solve(IReadOnlyCollection<string> input)
    {
        var state = ReadInitialState(input);

        // First 10 lines are used to describe the initial state.
        foreach (var instruction in input.Skip(10))
        {
            var components = instruction.Split(' ');
            var count = int.Parse(components[1]);
            var from = int.Parse(components[3]);
            var to = int.Parse(components[5]);

            for (int i = 0; i < count; i++)
            {
                if (state[from].TryPop(out var takenChar))
                {
                    state[to].Push(takenChar);
                }
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

    private static Stack<char>[] ReadInitialState(IReadOnlyCollection<string> input)
    {
        var state = new Stack<char>[10];
        for (int i = 1; i < 10; i++)
        {
            state[i] = new();
        }

        // Read until we reach the column numbers
        for (int lineIndex = 7; lineIndex >= 0; lineIndex--)
        {
            var currentLine = input.ElementAt(lineIndex);
            var currentColumn = 1;

            for (int i = 1; i < currentLine.Length - 1; i += 4)
            {
                if (char.IsLetterOrDigit(currentLine[i]))
                {
                    state[currentColumn].Push(currentLine[i]);
                }
                currentColumn++;
            }
        }

        return state;
    }
}
