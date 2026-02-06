
namespace Blog
{
    public class Posting(string? title, string? content, DateTime date, PostGenre genre) : Post (title, content, date)
    {
        public PostGenre Genre { get; set; } = genre;
        public override string Show() => base.Show() + $"Жанр: {Genre}";
    }
}
