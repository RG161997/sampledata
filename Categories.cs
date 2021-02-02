using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Sample.Models
{
    public class Categories
    {
        [Column("categoryId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int categoryId { get; set; }

        [Column("categoryName")]
        [Required]
        [StringLength(50)]
        public string categoryName { get; set; }

        [Column("description")]
        
        [StringLength(100)]
        public string description { get; set; }

        [Column("picture")]
        
        [StringLength(100)]
        public string picture { get; set; }

        public static implicit operator Categories(int v)
        {
            throw new NotImplementedException();
        }
    }
}
