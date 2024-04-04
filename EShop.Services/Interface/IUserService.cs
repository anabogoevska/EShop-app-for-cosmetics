using EShop.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Services.Interface
{
     public interface IUserService
    {
        public List<EShopApplicationUser> GetAll();
       
    }
}
