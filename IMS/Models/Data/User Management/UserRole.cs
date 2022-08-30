using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblUserRole")]
    public class UserRole : BaseClass
    {
        [Key]
        [Column("UserRoleID", Order = 0, TypeName = "int")]
        public int UserRoleID { get; set; }
        [Column("Role", Order = 1, TypeName = "nvarchar(255)")]
        [Required]
        public string Role { get; set; }
      


    }
}
