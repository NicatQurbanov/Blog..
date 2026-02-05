
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
                
                if (oldPost is  Posting posting && newPost is Posting newPosting) 
                    posting.Genre = newPosting.Genre;
                //else if (oldPost is News news && newPost is News newNews)
                    
            }
        }
    }
}
