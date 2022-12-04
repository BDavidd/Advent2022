﻿namespace AdventOfCode2022;

internal class Exercise1
{
    public int Solve(Stream input)
    {
        using var reader = new StreamReader(input);

        string? line;
        int max = 0;
        int current = 0;

        while ((line = reader.ReadLine()) != null)
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
