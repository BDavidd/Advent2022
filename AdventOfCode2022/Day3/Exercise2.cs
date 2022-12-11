namespace AdventOfCode2022.Day3;

internal static class Exercise2
{
    private const int FoundInFirstBag = 1;
    private const int FoundInSecondBag = 2;

    public static int Solve(IReadOnlyCollection<string> input)
    {
        var totalScore = 0;
        for (var i = 0; i < input.Count - 2; i += 3)
        {
            var state = new int[53];

            var firstPriorities = input.ElementAt(i).ToPriorities();
            foreach (var item in firstPriorities)
            {
                state[item] = FoundInFirstBag;
            }

            var secondPriorities = input.ElementAt(i + 1).ToPriorities();
            foreach (var item in secondPriorities)
            {
                if (state[item] == FoundInFirstBag)
                {
                    state[item] = FoundInSecondBag;
                }
            }

            var thirdPriorities = input.ElementAt(i + 2).ToPriorities();
            foreach (var item in thirdPriorities)
            {
                if (state[item] == FoundInSecondBag)
                {
                    totalScore += item;
                    break;
                }
            }
        }

        return totalScore;
    }
}
