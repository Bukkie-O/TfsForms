using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class tblRE
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]public string REType { get; set; }
        [StringLength(10)]public string REAcronym { get; set; }
        [StringLength(100)]public string REName { get; set; }
        public List<tblREPerson> REPersons { get; set; } = new();
    }
}
