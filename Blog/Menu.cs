using Blog.Model.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog
{
    public class Menu(PostController posts)
    {
        public PostController Posts { get; set; } = posts;

        public void Start()
        {
            Posts.Welcome();
            Console.WriteLine("1. Enter as user\n2. Enter as admin\n");
            ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();

            switch(key.KeyChar)
            {
                case '1':
                    User();
                    break;
                case '2':
                    Admin();
                    break;
            }
            Repeat();
        }

        public void User()
        {
            Posts.Welcome();
            Console.WriteLine("1. Watch all posts\n2. Watch only news.\n3. Watch only blog posts" +
                "\n\nSort by:\n\n ~~~News~~~\n\n a. Watch weather forecast\n " +
                                          "b. Economics" +
                             "\n\n~~~Postings~~~\n\n" +
                                          "c. Наука\n" +
                                          "d. Дети\n" +
                                          "e. Технологии\n" +
                                          "f. Здоровье\n" +
                                          "g. Искусство\n" +
                                          "h. Другое\n");

            ConsoleKeyInfo key = Console.ReadKey();

            switch( key.KeyChar)
            {
                case '1':
                    Posts.Show();
                    break;
                case '2':
                    Posts.Show(Posts.GetNews());
                    break;
                case '3':
                    Posts.Show(Posts.GetPostings());
                    break;
                case 'a':
                    Posts.Show(Posts.GetWeatherForecast());
                    break;
                case 'b':
                    Posts.Show(Posts.GetEconomics());
                    break;
                case 'c':
                    Posts.Show(Posts.GetScience());
                    break;
                case 'd':
                    Posts.Show(Posts.GetKids());
                    break;
                case 'e':
                    Posts.Show(Posts.GetTech()); 
                    break;
                case 'f':
                    Posts.Show(Posts.GetHealth());
                    break;
                case 'g':
                    Posts.Show(Posts.GetArts());
                    break;
                case 'h':
                    Posts.Show(Posts.GetMiscellaneous());
                    break;
            }
        }

        public void Admin()
        {
            Posts.Welcome();
            Console.WriteLine("1. Add post\n2. Update post\n3. Delete post");

            ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();
            switch(key.KeyChar)
            {
                case '1':
                    AddMenu();
                    break;
                case '2':
                    Console.WriteLine("Help. I can't do that.");
                    break;
                case '3':
                    Posts.Delete(GetIndex());
                    break;
            }
        }
       
        private void Repeat()
        {
            Console.ReadLine();
            Start();
        }

        //CREATING

        public void AddMenu()
        {
            Posts.Welcome();
            Console.WriteLine("1. News\n2. Posting");
            ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();

            Console.Write("\nTitle: ");
            string? title = Console.ReadLine();
            Console.Write("\nContent: ");
            string? content = Console.ReadLine();
            
            switch (key.KeyChar)
            {
                case '1':
                    Posts.AddPost(CreateNews(title, content));
                    break;
                case '2':
                    Posts.AddPost(new Posting(title, content, DateTime.Now, ShowGenres()));
                    break;
            }
            
        }

        public static PostGenre ShowGenres()
        {
            Console.WriteLine($"\nGenres: \n1. {PostGenre.Искусство}\n" +
                              $"2. {PostGenre.Наука}\n" +
                              $"3. {PostGenre.Здоровье}\n" +
                              $"4. {PostGenre.Дети}\n" +
                              $"5. {PostGenre.Технологии}\n" +
                              $"Choose the genre of article is about: ");

            ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();
            switch(key.KeyChar)
            {
                case'1':
                    return PostGenre.Искусство;
                case '2':
                    return PostGenre.Наука;
                case '3':
                    return PostGenre.Здоровье;
                case '4':
                    return PostGenre.Дети;
                case '5':
                    return PostGenre.Технологии;
            }
            return PostGenre.Другое;
        }
        
        public static News? CreateNews(string title, string content)
        {
            Console.Write("Source: ");
            string? source = Console.ReadLine();
            Console.WriteLine("\n1. Economics\n" +
                              "2. Weather Forecast.");

            ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();

            switch(key.KeyChar)
            {
                case '1':
                    Console.WriteLine("New currency: ");
                    decimal.TryParse(Console.ReadLine(), out decimal currency);
                    return new Economics(title, content, DateTime.Now, source, currency);
                case '2':
                    Console.WriteLine("Temperature: ");
                    int.TryParse(Console.ReadLine(), out int temp);
                    return new WeatherForecast(title, content, DateTime.Now, source, temp);
            }
            return null;
        }

        // UPDATING

        //public void UpdateMenu()
        //{
        //    Posts.Show();
        //    Console.WriteLine("Choose the id of post you want to work on: ");
        //    int.TryParse(Console.ReadLine(), out int index);

             

        //}

        // DELETING
        public int GetIndex()
        {
            Posts.Show();
            Console.WriteLine("\nChoose the id of post you want to work on: ");
            int.TryParse(Console.ReadLine(), out int index);
            return index;
        }
    }
}
