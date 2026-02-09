using Microsoft.AspNetCore.Identity;

namespace TfsForms.Models
{
    public class ApplicationUser:IdentityUser
    {
        public virtual tblTempRE? TempRE { get; set; }
        public int? TempREId { get; set; }
        public int? GoAMLReportingEntityId { get; set; }
        public string? RapidAMLReportingEntityId { get; set; }
        public string? CRIMSReportingEntityId { get; set; }
    }
}
