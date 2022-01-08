using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Category of products")]
        public string Category { get; set; }
        public string Company { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public string Size { get; set; }
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public int CourierID { get; set; }
        public Courier Courier { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
