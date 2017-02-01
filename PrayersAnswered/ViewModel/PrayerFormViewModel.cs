using System.ComponentModel.DataAnnotations;

namespace PrayersAnswered.ViewModel
{
    public class PrayerFormViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string  Content { get; set; }
        
    }
}