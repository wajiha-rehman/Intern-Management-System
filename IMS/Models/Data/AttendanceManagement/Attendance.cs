using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblAttendance")]
    public class Attendance : BaseClass
    {
        [Column("AttendanceID", Order = 0, TypeName = "int")]
        [Required]
        [Key]
        public int AttendanceID { get; set; }
        [Column("AttendanceDate", Order = 1, TypeName = "DateTime")]
        [Required]
        public DateTime AttendanceDate { get; set; }
        [Column("CheckOutTime", Order = 2, TypeName = "DateTime")]
        [Required]
        public DateTime CheckOutTime { get; set; }
        [Column("CheckInTime", Order = 3, TypeName = "DateTime")]
        [Required]
        public DateTime CheckInTime{ get; set; }
        [Column("Intern", Order = 4)]
        [Required]
        [ForeignKey("Intern")]
        public InternDetails Intern { get; set; }

    }
}
