using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Employees
    {
        [Column("employeeId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int employeeID { get; set; }

        [Column("lastName")]
        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        [Column("firstName")]
        [Required]
        [StringLength(50)]
        public string firstName { get; set; }

        [Column("title")]
        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [Column("titleOfCourtesy")]
        [Required]
        [StringLength(50)]
        public string titleOfCOurtesy { get; set; }

        [Column("birthDate")]
        [Required]
        [StringLength(50)]
        public string birthDate { get; set; }

        [Column("hireDate")]
        [Required]
        [StringLength(50)]
        public string hireDate { get; set; }

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

        [Column("homePhone")]
        [Required]
        public int homePhone { get; set; }

        [Column("extension")]
      
        public string extension { get; set; }


        [Column("photo")]
        [StringLength(500)]
        public string photo { get; set; }

        [Column("notes")]
        [StringLength(500)]
        public string notes { get; set; }

        [Column("reportsTo")]
        
        public string reportsTo { get; set; }

        [Column("photoPath")]
        [StringLength(200)]
        public string photoPath { set; get; }


    }
}
