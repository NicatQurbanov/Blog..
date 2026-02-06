

namespace Blog.Model.News
{
    internal class Economics(string? title, string? content, DateTime date, string? source, decimal? currency) : News(title, content, date, source)
    {
        public decimal? Currency { get; set; } = currency;

        public override string Show()
        {
            return base.Show() + $"\nCurrency: {Currency :C}";
        }
    }
}
