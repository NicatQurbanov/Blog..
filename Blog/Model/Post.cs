
namespace Blog
{
    public class Post(string? title, string? content, DateTime date)
    {
        private static int id = 1;
        public int Id { get; } = id++;
        public string? Title { get; set; } = title;
        public string? Content { get; set; } = content;
        public string Date { get; set; } = date.TimeOfDay.ToString("hh\\:mm\\:ss");

        public virtual string Show() => $"\n{Id}.\n"+
                                        $"Title: {Title}\n" +
                                        $"Content: {Content}\n" +
                                        $"Date: {Date}\n";
    }
}
