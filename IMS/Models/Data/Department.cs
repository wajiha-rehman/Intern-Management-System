using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblDepartment")]
    public class Department
    {
        [Column]
        [Required]
        public int DepartmentID { get; set; }
        [Column]
        [Required]
        public string DepartmentTitle { get; set; }
        [Column]
        [Required]
        public string DepartmentExtension { get; set; }
        [Column]
        [Required]
        public string DepartmentLocation { get; set; }
        [Column]
        [Required]
        public string DepartmentFloor { get; set; }
        [Column]
        [Required]
        public string DepartmentBuilding { get; set; }
        [Column]
        [ForeignKey("Manager")]
        public Manager Manager { get; set; }
    }
}
