using System;
using System.Collections.Generic;

namespace PrayersAnswered.Models
{
    public class Prayer
    {
        public int Id { get; set; }
        public ApplicationUser Poster { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsAnswered { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int PrayingForYou { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}