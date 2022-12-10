namespace AdventOfCode2022.Day2;
internal static class GameRules
{
    private const string OwnRock = "X";
    private const string OwnPaper = "Y";
    private const string OwnScissors = "Z";

    private const string OtherRock = "A";
    private const string OtherPaper = "B";
    private const string OtherScissors = "C";

    private const int RockBonus = 1;
    private const int PaperBonus = 2;
    private const int ScissorsBonus = 3;

    private const int LoseScore = 0;
    private const int DrawScore = 3;
    private const int WinScore = 6;

    public static int GetScore(string ownChoice, string otherChoice)
        => ownChoice switch
        {
            OwnRock => GetForRock(otherChoice),
            OwnPaper => GetForPaper(otherChoice),
            OwnScissors => GetForScissors(otherChoice),
            _ => throw new ArgumentException()
        };

    private static int GetForRock(string other)
        => other switch
        {
            OtherRock => RockBonus + DrawScore,
            OtherPaper => RockBonus + LoseScore,
            OtherScissors => RockBonus + WinScore,
            _ => throw new ArgumentException()
        };

    private static int GetForPaper(string other)
        => other switch
        {
            OtherRock => PaperBonus + WinScore,
            OtherPaper => PaperBonus + DrawScore,
            OtherScissors => PaperBonus + LoseScore,
            _ => throw new ArgumentException()
        };

    private static int GetForScissors(string other)
        => other switch
        {
            OtherRock => ScissorsBonus + LoseScore,
            OtherPaper => ScissorsBonus + WinScore,
            OtherScissors => ScissorsBonus + DrawScore,
            _ => throw new ArgumentException()
        };
}
