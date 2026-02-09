using System.ComponentModel.DataAnnotations;

namespace TfsForms.Models
{
    public class lkGoAMLRE
    {
       
            [Key]
            public int Id { get; set; }
            public int GoAMLId { get; set; }
            public string OrganizationName { get; set; }
        
    }
}
