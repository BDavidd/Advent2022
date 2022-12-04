namespace AdventOfCode2022;

internal class Exercise2
{
    public int Solve(Stream input)
    {
        using var reader = new StreamReader(input);
        string? line;
        var values = new List<int>();
        int current = 0;

        while ((line = reader.ReadLine()) != null)
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
