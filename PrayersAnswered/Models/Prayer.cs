using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrayersAnswered.Models
{
    public class Prayer
    {
        public int Id { get; set; }
        public ApplicationUser Poster { get; set; }
        [Required]
        public string PosterId { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsAnswered { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int PrayingForYou { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}