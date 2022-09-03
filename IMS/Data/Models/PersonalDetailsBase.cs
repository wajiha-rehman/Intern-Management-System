using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    public class PersonalDetailsBase : BaseClass
    {
        [Column]
        [Required]
        public int EmployeeID { get; set; }
        [Column]
        [Required]
        public string CNICNum { get; set; }
        [Column]
        [Required]
        public string FirstName { get; set; }
        [Column]
        [Required]
        public string LastName { get; set; }
        [Column]
        [Required]
        public string ContactNum { get; set; }
        [Column]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Column]
        [Required]
        public string Address { get; set; }
        [Column]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Column]
        [Required]
        public DateTime JoinDate { get; set; }
        [Column] 
        public DateTime LastWorkingDate { get; set; }
        [Column]
        [ForeignKey("UserID")]
        public int UserID { get; set; }
    }
}
