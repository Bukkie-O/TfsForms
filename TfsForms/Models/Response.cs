using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class Response
    {
        [Key] public int Id { get; set; }
        public virtual Designee Designee { get; set; }
        public int DesigneeId { get; set; }
        //public virtual ReportingEntity ReportingEntity { get; set; }
        public int ReportingEntityId { get; set; }
        public virtual Question Question { get; set; }
        public int QuestionId { get; set; }
        [StringLength(2000)] public string Answer { get; set; } = string.Empty;
        public bool IsDraft { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public List<FalsePositive> FalsePositives { get; set; } = new();
    }
}
