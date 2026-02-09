using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class Designee
    {
        [Key] public int Id { get; set; }


        [StringLength(255)] public string Name { get; set; } = default!;
        [StringLength(10)] public string DesignationType { get; set; }= default!;
        [StringLength(20)] public string RcNumber { get; set; }= default!;
        public DateTime DateDesignated { get; set; }= default!;
        [StringLength(50)] public string NslPermanentNumber  { get; set; } = default!;
        [StringLength(100)] public string OriginatingLea { get; set; } = default!;
        public List<Response> Responses { get; set; } = new();
        public List<FalsePositive> FalsePositives { get; set; } = new();
        public List<Asset> Assets { get; set; } = new();
        public List<Associate> Associates { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Nullable<DateTime> UpdatedAt { get; set; }

    }
}
