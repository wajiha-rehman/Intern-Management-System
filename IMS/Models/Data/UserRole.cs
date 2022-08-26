using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblUserRole")]
    public class UserRole : BaseClass
    {
        [Key]
        public int UserRoleID { get; set; }
        [Column]
        [Required]
        public string Role { get; set; }
      


    }
}
