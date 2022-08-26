using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblProgram")]
    public class Program : BaseClass
    {
        [Column]
        [Required]
        public int ProgramID { get; set; }
        [Column]
        [Required]
        public string ProgramTitle { get; set; }
        [Column]
        [Required]
        public string TransportAllowance { get; set; }
        [Column]
        [Required]
        public int CasualLeavesAllowed { get; set; }
        [Column]
        [Required]
        public int SickLeavesAllowed { get; set; }
        [Column]
        [Required]
        public string Duration { get; set; }
        [Column]
        [Required]
        public bool Open { get; set; }
        [Column]
        [Required]
        [ForeignKey("Department")]
        public Department Department { get; set; }

    }
}
