using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{   
    public enum Currency { 
        LBP
    }
    public class ProductPrice
    { 
        public string ProductPriceId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime ModifiedOn { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime PriceDate { get; set; }

        public string VariantId { get; set; }
        public Variant Variant { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public Currency Currency { get; set; }

    }
}