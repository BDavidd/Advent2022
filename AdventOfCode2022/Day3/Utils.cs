using System.Text;

namespace AdventOfCode2022.Day3;

internal static class Utils
{
    /// <summary>
    /// Lowercase letters ([97 - 122] in ASCII) are converted to [1 - 26].
    /// Uppercase letters ([65 - 90] in ASCII) are converted to [27 - 52].
    /// </summary>
    public static int[] ToPriorities(this string line)
        => Encoding.ASCII.GetBytes(line).Select((c, i) => char.IsLower(line[i]) ? c - 96 : c - 38).ToArray();
}
