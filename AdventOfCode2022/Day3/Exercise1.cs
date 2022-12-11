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
}
