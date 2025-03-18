namespace MusicLibrary;

public class Artist
{
    private string name;
    private DateTime? dateOfBirth;
    private List<Album> albums;

    public Artist(string name, DateTime? dateOfBirth)
    {
        this.Name = name;
        this.DateOfBirth = dateOfBirth;
        this.albums = new List<Album>();
    }

    public string Name
    {
        get => this.name;
        private set => this.name = string.IsNullOrEmpty(value) ? throw new ArgumentException("Name cannot be null or empty.", nameof(value)) : value;
    }

    public DateTime? DateOfBirth
    {
        get => this.dateOfBirth;
        init => this.dateOfBirth = value > DateTime.Now || value < DateTime.MinValue ? throw new ArgumentOutOfRangeException(nameof(value)) : value;
    }

    public override string ToString() => $"{this.Name} ({this.DateOfBirth})";
}
