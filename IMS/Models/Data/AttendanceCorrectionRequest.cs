using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblAttendanceCorrectionRequest")]
    public class AttendanceCorrectionRequest : BaseClass
    {
        [Column]
        [Required]
        public int AttCorrectionReqID { get; set; }
        [Column]
        [Required]
        [ForeignKey("Attendance")]
        public Attendance AttendanceID { get; set; }
        [Column]
        [Required]
        public string AttendanceType { get; set; }
        [Column]
        [Required]
        public DateTime AttendanceDate { get; set; }
        [Column]
        [Required]
        public DateTime NewAttendanceTime { get; set; }
        [Column]
        [Required]
        public string Reason { get; set; }
        [Column] 
        public bool ApprovedStatus { get; set; }
    }
}
