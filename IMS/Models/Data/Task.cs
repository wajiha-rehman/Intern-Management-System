using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblTask")]
    public class Task : BaseClass
    {
        [Column]
        [Required]
        public int TaskID { get; set; }
        [Column]
        [Required]
        public string TaskDescription { get; set; }
        [Column]
        [Required]
        [ForeignKey("Intern")]
        public Intern AssignedTo { get; set; }
        [Column]
        [Required]
        public DateTime AssignedDate { get; set; }
        [Column]
        public DateTime StartDate { get; set; }
        [Column]
        public DateTime CompletedDate { get; set; }
        [Column]
        [Required]
        public string Status { get; set; }
        [Column]
        public string InternRemarks { get; set; }
        [Column]
        public string ManagerFeedback { get; set; }
    }
}
