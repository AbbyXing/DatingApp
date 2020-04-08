namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; }  // user who like
        public int LikeeId { get; set; } // user who was liked
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}