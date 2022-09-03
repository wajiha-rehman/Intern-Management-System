using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblUser")]
    public class User : BaseClass
    {
        [Key]
        [Column("UserID",Order = 0, TypeName = "int")]
        public int UserID { get; set; }
        [Column("Username", Order = 1, TypeName = "nvarchar(255)")]
        [Required]
        public string Username { get; set; }
        [Column("Password", Order = 2, TypeName = "nvarchar(255)")]
        [Required]
        public string Password { get; set; }
        [Column("LastLogin", Order = 3, TypeName = "datetime")]
        [Required]
        public DateTime LastLogin { get; set; }
        [Column("FirstName", Order = 4, TypeName = "nvarchar(255)")]
        [Required]
        public string FirstName { get; set; }
        [Column("LastName", Order = 5, TypeName = "nvarchar(255)")]
        [Required]
        public string LastName { get; set; }
        [Column("Email", Order = 6, TypeName = "nvarchar(255)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Column("UserRole", Order = 7)]
        [Required]
        [ForeignKey("UserRoleID")]
        public int UserRoleID { get; set; }
        //public InternDetails Details { get; set; }
    }
}
