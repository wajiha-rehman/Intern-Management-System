using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblTask")]
    public class InternTask : BaseClass
    {
        [Column("TaskID",Order = 0,TypeName ="int")]
        [Required]
        [Key]
        public int TaskID { get; set; }
        [Column("TaskDescription", Order = 1, TypeName = "nvarchar(255)")]
        [Required]
        public string TaskDescription { get; set; }
        [Column("AssignedTo", Order = 2)]
        [Required]
        [ForeignKey("AssignedTo")]
        public InternDetails AssignedTo { get; set; }
        [Column("AssignedDate", Order = 3,TypeName ="DateTime")]
        [Required]
        public DateTime AssignedDate { get; set; }
        [Column("StartDate", Order = 4, TypeName = "DateTime")]
        public DateTime StartDate { get; set; }
        [Column("CompletedDate", Order = 5, TypeName = "DateTime")]
        public DateTime CompletedDate { get; set; }
        [Column("Status", Order = 6, TypeName = "int")]
        [Required]
        public int Status { get; set; }
        [Column("InternRemarks", Order = 7, TypeName = "nvarchar(MAX)")]
        public string InternRemarks { get; set; }
        [Column("ManagerFeedback", Order = 8, TypeName = "nvarchar(MAX)")]
        public string ManagerFeedback { get; set; }
    }
}
