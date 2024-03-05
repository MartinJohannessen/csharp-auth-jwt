using exercise.wwwapi.Models.user;

namespace exercise.wwwapi.Models.post
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
