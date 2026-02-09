using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TfsForms.Models
{
    [Index(nameof(AccountNumber), IsUnique = false)]
    public class FalsePositive
    {
        [Key] public int Id { get; set; }
        public virtual Response Response { get; set; }
        [Required] public int ResponseId { get; set; }
        [StringLength(255),Required] public string MatchedName { get; set; } = string.Empty;
        [StringLength(10), RegularExpression(@"^\d{10}$", ErrorMessage = "Must be exactly 10 digits")] public string? AccountNumber { get; set; }
        [StringLength(11), RegularExpression(@"^\d{11}$", ErrorMessage = "Must be exactly 11 digits")] public string? BVN { get; set; }
        [StringLength(50)] public string? AdditionalIdentifiers { get; set; } //BVN, RC Number, Telephone, etc
        [StringLength(255)] public string? Remarks { get; set; }
        [NotMapped]public string latest { get; set; } = "no";
    }
}
