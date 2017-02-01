using System.ComponentModel.DataAnnotations;

namespace PrayersAnswered.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public ApplicationUser Commentor { get; set; }
        public int UpVote { get; set; }
        [Required]
        public string Content { get; set; }
        public Prayer prayer { get; set; }
    }
}