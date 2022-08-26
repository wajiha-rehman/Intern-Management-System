using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblRecruiter")]
    public class Recruiter : PersonalDetailsBase
    {
        [Column]
        [Required]
        public int RecruiterID { get; set; }
    }
}
