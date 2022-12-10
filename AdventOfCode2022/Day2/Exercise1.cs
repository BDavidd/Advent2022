﻿namespace AdventOfCode2022.Day2;

internal static class Exercise1
{
    public static int Solve(IReadOnlyCollection<string> input)
    {
        var totalScore = 0;

        foreach (var line in input)
        {
            var entries = line.Split(' ');
            totalScore += GameRules.GetScore(entries[1], entries[0]);
        }

        return totalScore;
    }
}
