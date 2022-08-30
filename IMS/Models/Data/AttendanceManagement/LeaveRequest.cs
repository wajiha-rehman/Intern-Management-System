using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblLeaveRequest")]
    public class LeaveRequest : BaseClass
    {
        [Column("LeaveRequestID",Order =0,TypeName = "int")]
        [Required]
        [Key]
        public int LeaveRequestID { get; set; }
        [Column("Intern", Order = 1)]
        [Required]
        [ForeignKey("Intern")]
        public InternDetails Intern { get; set; }
        [Column("LeaveType", Order = 2, TypeName = "nvarchar(255)")]
        [Required]
        public string LeaveType { get; set; }
        [Column("LeaveStartDate", Order = 3, TypeName = "datetime")]
        [Required]
        public DateTime LeaveStartDate { get; set; }
        [Column("LeaveEndDate", Order = 4, TypeName = "datetime")]
        [Required]
        public DateTime LeaveEndDate { get; set; }
        [Column("Reason", Order = 5, TypeName = "nvarchar(255)")]
        public string Reason { get; set; }
        [Column("ApprovedStatus", Order = 6, TypeName = "bit")]
        public bool ApprovedStatus { get; set; }
    }
}
