using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class ProductCategory
    { 
        public string ProductCategoryId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime ModifiedOn { get; set; } = DateTime.Now;

        public string ProductGroupId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}