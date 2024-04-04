using EShop.Domain.Identity;
using EShop.Repository.Implementation;
using EShop.Repository.Interface;
using EShop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Services.Implementation
{
    public class UserService : IUserService
    {
      
            private readonly UserRepository _userRepository;

            public UserService(UserRepository userRepository)
            {
            _userRepository = userRepository;
            }
           
            public List<EShopApplicationUser> GetAll()
            {
            return (List<EShopApplicationUser>)this._userRepository.GetAll();
            }

         
        }
    }

