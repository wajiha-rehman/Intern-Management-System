using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the IMSApplicationUser class
    public class IMSApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string firstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string lastName { get; set; }

    }
}
