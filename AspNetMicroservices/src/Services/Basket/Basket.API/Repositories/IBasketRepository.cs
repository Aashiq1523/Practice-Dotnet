﻿using Basket.API.Entites;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);
    }
}
