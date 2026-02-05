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
                    break;
                default:
                    Start();
                    break;
            }
            Posts.Show(Posts.GetEconomics());
        }

        public void User()
        {
            Posts.Welcome();
            Console.WriteLine("1. Watch all posts\n2. Watch only news.\n3. Watch only blog posts");
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
                default:
                    User();
                    break;
            }
        }

       
    }
}
