using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class Asset
    {
        [Key] public int Id { get; set; }
        public virtual Response Response { get; set; }
        [Required] public int ResponseId { get; set; }
        [StringLength(255)] public string? AssetType { get; set; } = string.Empty;
        [Precision(18, 2)] public decimal EstimatedValue { get; set; }
        [StringLength(3)] public string Currency { get; set; }
        [StringLength(255)] public string? Remarks { get; set; }


    }
}
