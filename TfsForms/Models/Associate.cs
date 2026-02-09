using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    [Index(nameof(AccountNumber), IsUnique = false)]
    public class Associate
    {
        [Key] public int Id { get; set; }
        public virtual Response Response { get; set; }
        [Required] public int ResponseId { get; set; }
        [StringLength(255)] public string AssociateName { get; set; } = string.Empty;
        [StringLength(50)] public string RelationshipType { get; set; } = string.Empty;
        [StringLength(10), RegularExpression(@"^\d{10}$", ErrorMessage = "Must be exactly 10 digits")] public string? AccountNumber { get; set; }
        [StringLength(100)] public string? AdditionalIdentifiers { get; set; }  //BVN, RC Number, Telephone, etc
        [StringLength(255)] public string? Remarks { get; set; }


    }
}
