using ECommerce_Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_API.Models
{
    public class ApplicationUser:IdentityUser
    {
        public List<Order> Orders { get; set; }
        public string City { get; set; }
    }
}
