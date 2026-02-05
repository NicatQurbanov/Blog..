namespace Blog.Model.News
{
    public abstract class News(string title, string content, DateTime date, string source) : Post(title, content, date)
    {
        public string Source { get; set; } = source;
        public override string Show() => base.Show() + $"Source: {Source}";
    }
}
