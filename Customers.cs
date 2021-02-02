using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Customers
    {
        [Column("customerId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int customerId { get; set; }

        [Column("companyName")]
        [Required]
        [StringLength(50)]
        public string companyName { get; set; }

        [Column("contactName")]
        [Required]
        [StringLength(50)]
        public string contactName { get; set; }

        [Column("contactTitle")]
        [Required]
        [StringLength(50)]
        public string contactTitle { get; set; }

        [Column("Address")]
        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Column("city")]
        [Required]
        [StringLength(100)]
        public string city { get; set; }

        [Column("region")]
        [Required]
        [StringLength(100)]
        public string region { get; set; }

        [Column("postalCode")]
        [Required]

        public int postalCode { get; set; }

        [Column("country")]
        [Required]
        [StringLength(100)]
        public string country { get; set; }

        [Column("phone")]
        [Required]
        public int phone { get; set; }

        [Column("fax")]
       
        public string fax { get; set; }
    }
}
