using Microsoft.AspNetCore.Identity;

namespace exercise.wwwapi.Models.user
{
    public enum Role
    {
        Admin,
        User
    }

    public class User : IdentityUser
    {
        public Role Role { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
