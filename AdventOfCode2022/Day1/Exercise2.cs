namespace AdventOfCode2022.Day1;

internal static class Exercise2
{
    public static int Solve(IReadOnlyCollection<string> input)
    {
        var values = new List<int>();
        int current = 0;

        foreach (var line in input)
        {
            if (string.IsNullOrEmpty(line))
            {
                values.Add(current);
                current = 0;
            }
            else
            {
                current += int.Parse(line);
            }
        }

        return values.OrderByDescending(v => v).Take(3).Sum();
    }
}
