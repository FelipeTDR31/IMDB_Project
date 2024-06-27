namespace backend.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Rating { get; set; } = string.Empty;


    public static List<Movie> GetAllMovies() {
        using var context = new ApplicationDbContext();
        return context.Movies.ToList();
    }

    public static Movie GetMovieById(int id) {
        using var context = new ApplicationDbContext();
        return context.Movies.FirstOrDefault(m => m.Id == id);
    }

    public static void AddMovie(Movie movie) {
        using var context = new ApplicationDbContext();
        context.Movies.Add(movie);
        context.SaveChanges();
    }

    public static void UpdateMovie(Movie movie) {
        using var context = new ApplicationDbContext();
        context.Movies.Update(movie);
        context.SaveChanges();
    }

    public static void DeleteMovie(int id) {
        using var context = new ApplicationDbContext();
        var movie = context.Movies.FirstOrDefault(m => m.Id == id);
        if (movie != null) {
            context.Movies.Remove(movie);
            context.SaveChanges();
        }
    }

}
