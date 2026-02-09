using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)] public string QuestionText{ get; set; }
        [StringLength(20)] public string QuestionType { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; } = true;
        public List<Response> Responses { get; set; } = default!;
    }
}
