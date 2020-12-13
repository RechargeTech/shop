using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Product
    { 
        public string ProductId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        public string CompanyId { get; set; }

        public string ProductSubcategoryId { get; set; }

        public string ProductNo { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Size { get; set; }

        public bool IsActive { get ; set; }

    }
}