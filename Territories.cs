using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Territories
    {
        [Column("territoryId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int territoryId { get; set; }

        [Column("territoryDescription")]
        [Required]
        [StringLength(100)]
        public string territoryDescription { get; set; }

        [ForeignKey("regionId")]
        public virtual Region Region { get; set; }


    }
}
