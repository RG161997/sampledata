using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Shippers
    {
        [Column("shipperId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int shipperId { get; set; }

        [Column("companyName")]
        [Required]
        [StringLength(50)]
        public string companyName { get; set; }

        [Column("phone")]
        public int phone { get; set; }
    }
}
