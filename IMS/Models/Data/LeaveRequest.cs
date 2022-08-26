using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblLeaveRequest")]
    public class LeaveRequest : BaseClass
    {
        [Column]
        [Required]
        public int LeaveRequestID { get; set; }
        [Column]
        [Required]
        [ForeignKey("Intern")]
        public Intern Intern { get; set; }
        [Column]
        [Required]
        public string LeaveType { get; set; }
        [Column]
        [Required]
        public string LeaveStartDate { get; set; }
        [Column]
        [Required]
        public string LeaveEndDate { get; set; }
        [Column] 
        public string Reason { get; set; }
        [Column]
        public bool ApprovedStatus { get; set; }
    }
}
