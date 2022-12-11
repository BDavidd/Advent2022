namespace InputReader
{
    public class InputProvider
    {
        private static readonly Dictionary<string, string> PathMap = new()
        {
            { ExerciseIds.Exercise1Day1, @"Input\Exercise1Day1.txt" },
            { ExerciseIds.Exercise2Day1, @"Input\Exercise1Day1.txt" },
            { ExerciseIds.Exercise1Day2, @"Input\Exercise1Day2.txt" },
            { ExerciseIds.Exercise2Day2, @"Input\Exercise1Day2.txt" }
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