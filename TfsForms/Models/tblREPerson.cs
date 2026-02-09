using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class tblREPerson
    {
        [Key]
        public int Id { get; set; }
        public virtual tblRE RE { get; set; }
        public int REId { get; set; }
        [StringLength(100)]public string UserCode { get; set; }
        [StringLength(100)]public string FirstName { get; set; }
        [StringLength(100)]public string LastName { get; set; }
    }
}
