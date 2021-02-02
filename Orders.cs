using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Orders
    {
        [Column("orderId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int orderId { get; set; }

        [ForeignKey("customerId")]
        public virtual Customers Customers { get; set; }

        [ForeignKey("employeeId")]
        public virtual Employees Employees { get; set; }


        [Column("orderDate")]
        [Required]
        [StringLength(100)]
        public string orderDate { get; set; }

        [Column("requiredDate")]
        [Required]
        [StringLength(100)]
        public string requiredDate { get; set; }

        [Column("shippedDate")]
        [Required]
        [StringLength(100)]
        public string shippedDate { get; set; }

        [Column("shipVia")]
        [StringLength(100)]
        public string shipVia { get; set; }

        [Column("freight")]
        [StringLength(50)]
        public string freigth { get; set; }

        [Column("shipName")]
        [StringLength(50)]
        public string shipName { get; set; }

        [Column("shipAddress")]
        [Required]
        [StringLength(100)]
        public string shipAddress { get; set; }

        [Column("shipCity")]
        [Required]
        [StringLength(100)]
        public string shipCity { get; set; }

        [Column("shipRegion")]
        [Required]
        [StringLength(100)]
        public string shipRegion { get; set; }

        [Column("shipPostalCode")]
        [Required]

        public int shipPostalCode { get; set; }

        [Column("shipCountry")]
        [Required]
        [StringLength(100)]
        public string shipCountry { get; set; }


    }
}
