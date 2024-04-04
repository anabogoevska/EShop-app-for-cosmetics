﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace EShop.Domain.DomainModels
{
    public class ProductInShoppingCart : BaseEntity
    {
   
        public Guid ProductId { get; set; }
        public virtual Product CurrnetProduct { get; set; }

        public Guid ShoppingCartId { get; set; }
        public virtual ShoppingCart UserCart { get; set; }

        public int Quantity { get; set; }
    }
}
