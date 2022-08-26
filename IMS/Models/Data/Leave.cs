using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Models.Data
{
    [Table("tblLeave")]
    public class Leave : BaseClass
    {
        [Column]
        [Required]
        public int LeaveID { get; set; }
        [Column]
        [Required]
        [ForeignKey("LeaveRequest")]
        public LeaveRequest LeaveRequest { get; set; }
    }
}
