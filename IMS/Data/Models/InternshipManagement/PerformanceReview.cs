using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblPerformanceReview")]
    public class PerformanceReview : BaseClass
    {
        [Column("ReviewID",Order = 0, TypeName = "int")]
        [Required]
        [Key]
        public int ReviewID { get; set; }
        [Column("Intern", Order = 1)]
        [Required]
        [ForeignKey("InternID")]
        public int InternID { get; set; }
        [Column("Remarks", Order = 2, TypeName = "nvarchar(255)")]
        public string Remarks { get; set; }
    }
}
