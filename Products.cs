using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Products
    {
        [Column("productId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int productId { get; set; }

        [Column("productName")]
        [Required]
        [StringLength(100)]
        public string productName { get; set; }

        [ForeignKey("categoryId")]
        public virtual Categories Categories { get; set; }

        [ForeignKey("supplierID")]
        public virtual Suppliers Suppliers { get; set; }

        [Column("quantityPerLabel")]
        [Required]
        public int quantitPerLabel { get; set; }

        [Column("unitPrice")]
        [Required]
        public int unitPrice { get; set; }

        [Column("unitsInStock")]
        [Required]
        public int unitsInStock { get; set; }

        [Column("unitsOnOrder")]
        [Required]
        public int unitsOnOrder { get; set; }

        [Column("reorderLevel")]

        public int reorderLevel { get; set; }

        [Column("discontinued")]
        [StringLength(20)]
        public string discontinued { get; set; }


    }
}
