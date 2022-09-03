using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblAttendanceCorrectionRequest")]
    public class AttendanceCorrectionRequest : BaseClass
    {
        [Column("AttCorrectionID",Order = 0, TypeName = "int")]
        [Required]
        [Key]
        public int AttCorrectionReqID { get; set; }
        [Column("AttendanceID", Order = 1, TypeName = "int")]
        [Required]
        [ForeignKey("AttendanceID")]
        public int AttendanceID { get; set; }
        [Column("AttendanceType", Order = 2, TypeName = "nvarchar(255)")]
        [Required]
        [ForeignKey("Attendance")] 
        public string AttendanceType { get; set; }
        [Column("AttendanceDate", Order = 3, TypeName = "datetime")]
        [Required]
        public DateTime AttendanceDate { get; set; }
        [Column("NewAttendanceTime", Order = 4, TypeName = "datetime")]
        [Required]
        public DateTime NewAttendanceTime { get; set; }
        [Column("Reason", Order = 5, TypeName = "nvarchar(255)")]
        [Required]
        public string Reason { get; set; }
        [Column("ApprovedStatus", Order = 6, TypeName = "bit")]
        public bool ApprovedStatus { get; set; }
    }
}
