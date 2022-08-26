using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblIntern")]
    public class Intern : PersonalDetailsBase
    {
        [Column]
        [Required]
        public int InternID { get; set; }
        [Column]
        [Required]
        public string PositionTitle { get; set; }
        [Column]
        [Required]
        public double Stipend { get; set; }
        [Column]
        [Required]
        public int CasualLeavesRemaining { get; set; }
        [Column]
        [Required]
        public int SickLeavesRemaining { get; set; }
        [Column]
        [Required]
        [ForeignKey("Program")]
        public Program Program { get; set; } 
        [Column]
        [Required]
        [ForeignKey("Recruiter")]
        public Recruiter HRRepresentative { get; set; }

    }
}
