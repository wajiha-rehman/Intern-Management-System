using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblAttendance")]
    public class Attendance : BaseClass
    {
        [Column]
        [Required]
        public int AttendanceID { get; set; }
        [Column]
        [Required]
        public DateTime AttendanceDate { get; set; }
        [Column]
        [Required]
        public DateTime CheckOutTime { get; set; }
        [Column]
        [Required]
        public DateTime CheckInTime{ get; set; }
        [Column]
        [Required]
        [ForeignKey("Intern")]
        public Intern Intern { get; set; }

    }
}
