namespace InputReader
{
    public class InputProvider
    {
        private static readonly Dictionary<string, string> PathMap = new()
        {
            { ExerciseIds.Day1, @"Input\Day1.txt" },
            { ExerciseIds.Day2, @"Input\Day2.txt" },
            { ExerciseIds.Day3, @"Input\Day3.txt" }
        };

        public static Stream GetInput(string exerciseId)
            => File.OpenRead(PathMap[exerciseId]);

        public static IReadOnlyCollection<string> GetStringInput(string exerciseId)
        {
            using var stream = File.OpenRead(PathMap[exerciseId]);
            using var reader = new StreamReader(stream);

            var input = new List<string>();
            string? readLine = null;

            while (!reader.EndOfStream && (readLine = reader.ReadLine()) != null) 
            {
                input.Add(readLine);
            }

            return input;
        }
    }
}