using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblDepartment")]
    public class Department : BaseClass
    {
        [Column("DepartmentID", Order = 0, TypeName = "int")]
        [Required]
        public int DepartmentID { get; set; }
        [Column("DepartmentTitle", Order = 2, TypeName = "nvarchar(255)")]
        [Required]
        public string DepartmentTitle { get; set; }
        [Required]
        [Column("DepartmentExtension", Order = 3, TypeName = "nvarchar(255)")]
        public string DepartmentExtension { get; set; }
        [Column("DepartmentLocation", Order = 4, TypeName = "nvarchar(255)")]
        [Required]
        public string DepartmentLocation { get; set; }
        [Column("DepartmentFloor", Order = 5, TypeName = "nvarchar(255)")]
        [Required]
        public string DepartmentFloor { get; set; }
        [Column("DepartmentBuilding", Order = 6, TypeName = "nvarchar(255)")]
        [Required]
        public string DepartmentBuilding { get; set; }
        [Column("Manager", Order = 7, TypeName = "int")]
        [ForeignKey("User")]
        public User Manager { get; set; }
    }
}
