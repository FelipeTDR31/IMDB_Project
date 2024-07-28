namespace backend.Entities;
using backend.Data;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Rating { get; set; } = string.Empty;

    
    public Movie(string title, string description, string genre, string rating)
    {
        this.Title = title;
        this.Description = description;
        this.Genre = genre;
        this.Rating = rating;
    }
}
