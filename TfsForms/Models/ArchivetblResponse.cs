using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class ArchivetblResponse
    {
        [Key] public int Id { get; set; }


        [StringLength(255)] public string ReportingEntityName { get; set; }
        [StringLength(255)] public string ReportingEntityCategory { get; set; }
        public virtual Designee Designee { get; set; }
        [Required] public int DesigneeId { get; set; }
        public bool HasRelationship { get; set; }
        [StringLength(255)] public string? AccountHolderName { get; set; }
        [StringLength(10), RegularExpression(@"^\d{10}$", ErrorMessage = "Must be exactly 10 digits")] public string? AccountNumber { get; set; }
        [StringLength(11), RegularExpression(@"^\d{11}$", ErrorMessage = "Must be exactly 11 digits")] public string? BVN { get; set; }
        [StringLength(3)] public string Currency { get; set; }
        public bool IsAccountFrozen { get; set; }
        public DateTime? DateFrozen { get; set; }
        [Precision(18,2)] public decimal? AmountFrozen { get; set; }
        [Precision(18, 2)] public decimal? CurrentBalance { get; set; }
        [StringLength(50)] public string? AccountType { get; set; }
        [StringLength(255)] public string? SuspiciousActivity { get; set; }
        [StringLength(255)] public string? LegalChallenges { get; set; }
        [StringLength(255)] public string? ComplianceSteps { get; set; }
        [StringLength(255)] public string? ImplementationObservations { get; set; }
        public bool IsFalsePositive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Nullable<DateTime> UpdatedAt { get; set; } = DateTime.UtcNow;
        public List<FalsePositive> FalsePositives { get; set; } = new();
        public List<Asset> Assets { get; set; } = new();
        public List<Associate> Associates { get; set; } = new();







    }
}
