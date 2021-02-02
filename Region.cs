using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Region
    {
        [Column("regionId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int regionId { get; set; }

        [Column("regionDescription")]
        [Required]
        [StringLength(100)]
        public string regionDescription { get; set; }
    }
}
