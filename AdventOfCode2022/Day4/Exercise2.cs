namespace AdventOfCode2022.Day4;

internal static class Exercise2
{
    public static int Solve(IReadOnlyCollection<string> input)
    {
        var count = 0;
        foreach (var entry in input)
        {
            var assignments = entry.Split(',');
            var leftRange = assignments[0].Split('-').Select(c => int.Parse(c)).ToArray();
            var rightRange = assignments[1].Split('-').Select(c => int.Parse(c)).ToArray();

            if (RangesOverlap(leftRange, rightRange) || RangesOverlap(rightRange, leftRange))
            {
                count++;
            }
        }

        return count;
    }

    private static bool RangesOverlap(int[] first, int[] second)
        => first[1] >= second[0] && first[0] <= second[0];
}
