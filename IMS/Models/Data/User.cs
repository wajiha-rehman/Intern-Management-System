using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblUser")]
    public class User : BaseClass
    {
        [Key]
        public int UserID { get; set; }
        [Column]
        [Required]
        public string Username { get; set; }
        [Column]
        [Required]
        public string Password { get; set; }
        [Column]
        [Required]
        public DateTime LastLogin { get; set; }
        [Column]
        [Required]
        public string FirstName { get; set; }
        [Column]
        [Required]
        public string LastName { get; set; }
        [Column]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Column]
        [Required]
        [ForeignKey("UserRole")]
        public UserRole UserRole { get; set; }
    }
}
