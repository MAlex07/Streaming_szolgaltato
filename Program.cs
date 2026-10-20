namespace Streaming_szolgaltato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamingPlatform platform = new StreamingPlatform();

            platform.LoadFile("catalog.txt");

            IContent longest = platform.GetLongest();

            if (longest != null)
            {
                Console.WriteLine("Leghosszabb tartalom: " + longest.GetTitle());
                Console.WriteLine("Hossza: " + longest.GetLength() + " perc");
            }
        }
    }
}
