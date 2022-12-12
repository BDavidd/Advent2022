namespace AdventOfCode2022.Day5;

internal class Utils
{
    public static Stack<char>[] ReadInitialState(IReadOnlyCollection<string> input)
    {
        var state = new Stack<char>[10];
        for (int i = 1; i < 10; i++)
        {
            state[i] = new();
        }

        // Read until we reach the column numbers
        for (int lineIndex = 7; lineIndex >= 0; lineIndex--)
        {
            var currentLine = input.ElementAt(lineIndex);
            var currentColumn = 1;

            for (int i = 1; i < currentLine.Length - 1; i += 4)
            {
                if (char.IsLetterOrDigit(currentLine[i]))
                {
                    state[currentColumn].Push(currentLine[i]);
                }
                currentColumn++;
            }
        }

        return state;
    }
}
