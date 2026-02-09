using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class tblTempRE
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]public string REName { get; set; }
    }
}
