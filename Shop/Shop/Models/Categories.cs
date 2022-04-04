using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public partial class Categories
    {
        [Key]
        [Column("cCode")]
        [StringLength(10)]
        public string CCode { get; set; }
        [Required]
        [Column("cName")]
        [StringLength(10)]
        public string CName { get; set; }
    }
}
