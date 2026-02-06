
using Blog.Model;
using Blog.Model.News;
using System.Runtime.Serialization;
using System.Text;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            PostController posts = new();


            posts.AddPost(new WeatherForecast("Погода в феврале", 
                "В городе ожидается снегопад и сильные ветры. Одевайтесь потеплее", 
                DateTime.Now, "BBC", 4));

            posts.AddPost(new Economics("Манат дешевеет", 
                "Цены на золото обвалили азербайджанский рынок", 
                DateTime.Now, "FoxNews", 5.99m));

            posts.AddPost(new Posting("Хобби как замена психологу", 
                "Британскими учеными доказано, наличие хобби снижает риск депрессии на 13%", 
                DateTime.Now, PostGenre.Здоровье));

            posts.AddPost(new Posting("Выставка Энди Уорхола", 
                "Ознакомьтесь с работами гения поп-культуры, Энди Уорхола, в галерее YARAT 10 февраля.", 
                DateTime.Now, PostGenre.Искусство));

            

            Menu menu = new(posts);
            menu.Start();
        }
    }
}