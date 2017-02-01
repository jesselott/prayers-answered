namespace PrayersAnswered.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public ApplicationUser Commentor { get; set; }
        public int UpVote { get; set; }
        public string Content { get; set; }
    }
}