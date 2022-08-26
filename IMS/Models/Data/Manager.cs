using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    [Table("tblManager")]
    public class Manager : PersonalDetailsBase
    {
        [Column]
        [Required]
        public int ManagerID { get; set; }
    }
}
