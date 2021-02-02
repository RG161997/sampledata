using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class OrderDetails
    {

        [ForeignKey("orderId")]
        public virtual Orders Orders { get; set; }

        [ForeignKey("productID")]
        public virtual Products Products { get; set; }


        [Column("unitPrice")]
        [Required]
        public int unitPrice { get; set; }

        [Column("quantity")]
        [Required]
        public int quantity { get; set; }

        [Column("discount")]

        public int discount { get; set; }





    }
}
