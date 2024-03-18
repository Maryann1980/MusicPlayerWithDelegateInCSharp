namespace MusicPlayerWithDelegateInCSharp
{
    internal class Program
    {
        static void Main()
        {
            MusicPlayerDelegate player = new MusicPlayerDelegate();

            // Subscribe to the events
            player.SongAdded += HandleSongAdded;
            player.SongDeleted += HandleSongDeleted;

            player.Run();
        }

        // Event handler methods
        static void HandleSongAdded(string message)
        {
            Console.WriteLine($"Event: {message}");
        }

        static void HandleSongDeleted(string message)
        {
            Console.WriteLine($"Event: {message}");
        }
    }
}
