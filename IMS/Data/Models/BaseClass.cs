using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models.Data
{
    public class BaseClass
    {
        [Column]
        [Required]
        public DateTime CreatedDate { get; set; }
        [Column]
        public DateTime UpdateDate { get; set; }
        [Column]
        [Required]
        public bool Active { get; set; }
    }
}
