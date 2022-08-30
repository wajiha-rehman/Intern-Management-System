using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblIntern")]
    public class InternDetails : PersonalDetailsBase
    {
        [Key]
        [Column("InternID",Order = 8, TypeName = "int")]
        [Required]
        public int InternID { get; set; } 
        [Required]
        [Column("PositionTitle", Order = 9, TypeName = "nvarchar(255)")]
        public string PositionTitle { get; set; }
        [Column("Stipend", Order = 10, TypeName = "money")]
        [Required]
        public double Stipend { get; set; }
        [Column("CasualLeavesRemaining", Order = 11, TypeName = "int")]
        [Required]
        public int CasualLeavesRemaining { get; set; }
        [Column("SickLeavesRemaining", Order = 12, TypeName = "int")]
        [Required]
        public int SickLeavesRemaining { get; set; }
        [Column("Program", Order = 13)]
        [Required]
        [ForeignKey("Program")]
        public InternshipProgram Program { get; set; }
        [Column("UserID", Order = 14)]
        [Required]
        [ForeignKey("User")]
        public User UserID { get; set; }
        [Column("HRRepresentative", Order = 15)]
        [Required]
        [ForeignKey("User")]
        public User HRRepresentative { get; set; }

    }
}
