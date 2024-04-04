using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EShop.Domain.DomainModels
{
    public class Product : BaseEntity
    {
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Product name")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Product image")]
        public string ProductImage { get; set; }
        [Required]
        [DisplayName("Product description")]
        public string ProductDescription { get; set; }
        [Required]
        [DisplayName("Product price")]
        public int ProductPrice { get; set; }
        [Required]
        [DisplayName("Rating")]
        public int Rating { get; set; }

        [Required]
        [DisplayName("Product quantity")]
        public int ProductQuantity { get; set; }

        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }

        public IEnumerable<ProductInOrder> ProductInOrders { get; set; }

    }
}
