
namespace Blog
{
    public class Posting(string title, string content, DateTime date, PostGenre genre) : Post (title, content, date)
    {
        public PostGenre Genre { get; set; } = genre;
        public string Content { get; } = content;
        public override string Show() => base.Show() + $"Genre: {Genre}";
    }
}
