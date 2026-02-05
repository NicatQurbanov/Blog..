using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.News
{
    public class WeatherForecast(string title, string content, DateTime date, string source, int temperature) : News(title, content, date, source)
    {
        public int Temperature { get; set; } = temperature;

        public override string Show() => base.Show() + $"\nТемпература: {(Temperature > 0 ? "+" : "-")}{Temperature}C";
    }
}
