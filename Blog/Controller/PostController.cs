
using Blog.Model.News;

namespace Blog
{
    public class PostController
    {
        public List<Post> Posts { get; set; } = new List<Post>();

        public void AddPost(Post post) => Posts.Add(post);

        public void Show()
        { 
            foreach (Post p in Posts) Console.WriteLine(p.Show());
        }

        public void Show(List<Post> posts)
        {
            foreach (Post p in posts) Console.WriteLine(p.Show());
        }

        public void Delete(Post post) => Posts.Remove(post);

        public void Delete(int id)
        {
            Post? post = Posts.FirstOrDefault(p => p.Id == id);

            if (post != null)
                Posts.Remove(post);
            else
                Console.WriteLine("The post has not been found.");
        }

        public void Update(int id, Post newPost)
        {
            Post? oldPost = Posts.FirstOrDefault(p => p.Id == id);

            if (oldPost != null)
            {
                oldPost.Title = newPost.Title;
                oldPost.Content = newPost.Content;

                if (oldPost is Posting posting && newPost is Posting newPosting)
                    posting.Genre = newPosting.Genre;
                else if (oldPost is News news && newPost is News newNews)
                    news.Source = newNews.Source;
            }
            else
                Console.WriteLine("Post not found.");
        }

        public List<Post> GetPostings() => [.. Posts.Where(p => p is Posting)];

        public List<Post> GetNews() => [.. Posts.Where(p => p is News)];

        public List<Post> GetWeatherForecast() => [.. Posts.Where(p => p is WeatherForecast)];

        public List<Post> GetEconomics() => [.. Posts.Where(p => p is Economics)];

        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("~~~News and Blog~~~\n\n");
        }
    }
}
