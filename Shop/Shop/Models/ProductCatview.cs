using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public partial class ProductCatview
    {
        [Required]
        [Column("pCode")]
        [StringLength(10)]
        public string PCode { get; set; }
        [Required]
        [Column("cCode")]
        [StringLength(10)]
        public string CCode { get; set; }
        [Required]
        [Column("cName")]
        [StringLength(10)]
        public string CName { get; set; }
        [Required]
        [Column("pName")]
        [StringLength(10)]
        public string PName { get; set; }
        [Column("pCost")]
        public int PCost { get; set; }
        [Column("pQuantity")]
        public int PQuantity { get; set; }
        [Column("pPrice")]
        public int PPrice { get; set; }
    }
}
