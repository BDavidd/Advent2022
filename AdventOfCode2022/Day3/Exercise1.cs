using System.Text;

namespace AdventOfCode2022.Day3;

internal static class Exercise1
{
    private const int FoundInFirstHalf = 1;
    private const int FoundInBothHalves = 2;

    public static int Solve(IReadOnlyCollection<string> input)
    {
        var totalScore = 0;
        foreach (var line in input)
        {
            var priorities = line.ToPriorities();
            var midPoint = priorities.Length / 2;
            var state = new int[53];
            
            for (var i = 0; i < midPoint; i++)
            {
                state[priorities[i]] = FoundInFirstHalf;
            }

            for (var i = midPoint; i < priorities.Length; i++)
            {
                var priority = priorities[i];
                if (state[priority] == FoundInFirstHalf)
                {
                    totalScore += priority;
                    state[priority] = FoundInBothHalves;
                }
            }
        }

        return totalScore;
    }

    /// <summary>
    /// Lowercase letters ([97 - 122] in ASCII) are converted to [1 - 26].
    /// Uppercase letters ([65 - 90] in ASCII) are converted to [27 - 52].
    /// </summary>
    private static int[] ToPriorities(this string line)
        => Encoding.ASCII.GetBytes(line).Select((c, i) => char.IsLower(line[i]) ? c - 96 : c - 38).ToArray();
}
