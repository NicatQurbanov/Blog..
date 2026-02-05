using Blog.Model;
using Blog.Model.News;
using System.Runtime.Serialization;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PostController posts = new();

            posts.AddPost(new News("Aktyor vefat etdi", "Namelum aktyor vefat edib", DateTime.Now));
            posts.AddPost(new News("FBI released new Epstein files", "The list of the new persons: ", DateTime.Now));

            posts.AddPost(new Posting("Scientists approved health benefits of this hobby", "Bread baking has crucical health benefits", DateTime.Now, PostGenre.Health));
            posts.AddPost(new Posting("Jeff Coons's new ggg", "gggg", DateTime.Now, PostGenre.Arts));

            
            posts.Show();
            

        }
    }
}