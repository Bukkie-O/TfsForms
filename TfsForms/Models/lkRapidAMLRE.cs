using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class lkRapidAMLRE
    {
        [Key]
        public int Id { get; set; }
        public string RapidAMLId { get; set; }
        public string OrganizationName { get; set; }
    }
}
