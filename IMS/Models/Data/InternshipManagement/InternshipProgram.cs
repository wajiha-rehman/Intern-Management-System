using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblProgram")]
    public class InternshipProgram : BaseClass
    {
        [Column("ProgramID",Order =0,TypeName ="int")]
        [Required]
        [Key]
        public int ProgramID { get; set; }
        [Column("ProgramTitle", Order = 1, TypeName = "nvarchar(255)")]
        [Required]
        public string ProgramTitle { get; set; }
        [Column("TransportAllowance", Order = 2, TypeName = "decimal(18,5)")]
        [Required]
        public double TransportAllowance { get; set; }
        [Column("CasualLeavesAllowed", Order = 3, TypeName = "int")]
        [Required]
        public int CasualLeavesAllowed { get; set; }
        [Column("SickLeavesAllowed", Order = 4, TypeName = "int")]
        [Required]
        public int SickLeavesAllowed { get; set; }
        [Column("Duration", Order = 5, TypeName = "string")]
        [Required]
        public string Duration { get; set; }
        [Column("Open", Order = 6, TypeName = "bit")]
        [Required]
        public bool Open { get; set; }
        [Column("Department", Order = 7)]
        [Required]
        [ForeignKey("Department")]
        public Department Department { get; set; }

    }
}
