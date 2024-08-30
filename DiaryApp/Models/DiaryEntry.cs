using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required(ErrorMessage = "The Date field is required.")]
        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}
