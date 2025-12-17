using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This is Error Message")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime Created { get; set; }
    }
}
