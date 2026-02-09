using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class lkCRIMSLEA
    {
        [Key]
        public int Id { get; set; }
        public string CRIMSId { get; set; }
        public string LEA { get; set; }
    }
}
