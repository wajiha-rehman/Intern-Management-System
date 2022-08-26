using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblPerformanceReview")]
    public class PerformanceReview : BaseClass
    {
        [Column]
        [Required]
        public int ReviewID { get; set; }
        [Column]
        [Required]
        [ForeignKey("Intern")]
        public Intern Intern { get; set; }
        public string Remarks { get; set; }
    }
}
