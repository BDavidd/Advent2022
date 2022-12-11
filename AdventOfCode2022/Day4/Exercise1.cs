namespace AdventOfCode2022.Day4;

internal static class Exercise1
{
    public static int Solve(IReadOnlyCollection<string> input)
    {
        var count = 0;
        foreach (var entry in input)
        {
            var assignments = entry.Split(',');
            var leftRange = assignments[0].Split('-').Select(c => int.Parse(c)).ToArray();
            var rightRange = assignments[1].Split('-').Select(c => int.Parse(c)).ToArray();

            if (IsContainnedWithin(leftRange, rightRange) || IsContainnedWithin(rightRange, leftRange))
            {
                count++;
            }
        }

        return count;
    }

    private static bool IsContainnedWithin(int[] biggerRange, int[] smallerRange)
        => biggerRange[0] <= smallerRange[0] && biggerRange[1] >= smallerRange[1];
}
