using ECommerce_API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Models
{
    public class Order
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Product Product { get; set; }
        public string ProdcutId { get; set; }
    }
}
