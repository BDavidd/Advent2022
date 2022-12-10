namespace AdventOfCode2022.Day1;

internal static class Exercise1
{
    public static int Solve(IReadOnlyCollection<string> input)
    {
        int max = 0;
        int current = 0;

        foreach (var line in input)
        {
            if (string.IsNullOrEmpty(line))
            {
                max = Math.Max(max, current);
                current = 0;
            }
            else
            {
                current += int.Parse(line);
            }
        }

        return max;
    }
}
