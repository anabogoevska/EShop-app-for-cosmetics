﻿using EShop.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Identity
{
    public class EShopApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        //za OneToOne relacijata megju ShoppingCart i User
        public virtual ShoppingCart UserCart { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
