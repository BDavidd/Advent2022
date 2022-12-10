namespace InputReader
{
    public class InputProvider
    {
        private static readonly Dictionary<string, string> PathMap = new()
        {
            { ExerciseIds.Exercise1Day1, @"Input\Exercise1Day1.txt" },
            { ExerciseIds.Exercise2Day1, @"Input\Exercise1Day1.txt" }
        };

        public static Stream GetInput(string exerciseId)
            => File.OpenRead(PathMap[exerciseId]);

        public static IReadOnlyCollection<string> GetStringInput(string exerciseId)
        {
            using var stream = File.OpenRead(PathMap[exerciseId]);
            using var reader = new StreamReader(stream);

            var input = new List<string>();

            while (!reader.EndOfStream) 
            {
                input.Add(reader.ReadLine());
            }

            return input;
        }
    }
}