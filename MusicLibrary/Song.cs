namespace MusicLibrary;

public class Song
{
    private string title;
    private readonly uint duration;
    private readonly Artist performer;

    public Song(string title, int duration)
    {
        this.title = !string.IsNullOrEmpty(title) ? title : throw new ArgumentException("Song title cannot be null or empty.");
        this.duration = duration < 0 ? throw new ArgumentException("Duration cannot be negative") : (uint)duration;
    }

    public string Title => this.title;
    public int MyProperty { get; set; }
    public int MyProperty1 { get; set; }
    // TODO: Define a private field to store the song's title
    // TODO: Define a private field to store the song's duration
    // TODO: Define a private field to store the song's performer



    // TODO: Create a constructor to initialize the song's title, duration, and performer



    // TODO: Implement a property to get and set the song's title with validation
    // TODO: Implement a property to get and set the song's duration with validation
    // TODO: Implement a property to get and set the song's performer with validation



    // TODO: Add the ToString method to return the song's title, duration, and performer as a string song representation


}
