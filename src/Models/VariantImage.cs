using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class VariantImage
    { 
        [Key]
        public string VariantImageId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime ModifiedOn { get; set; } = DateTime.Now;

        public string VariantId { get; set; }
        public Variant Variant { get; set; }

        public string Color { get; set; } //Example: #F6F6F6

        [Url]
        public string ImageURL { get; set; }
    }
}