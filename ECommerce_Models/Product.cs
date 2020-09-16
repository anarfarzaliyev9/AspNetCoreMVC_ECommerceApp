using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce_Models
{
    public class Product
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
   
        public Category Category { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
    
        public string PhotoPath { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNewArrival { get; set; }
    }
}
