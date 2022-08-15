using System;
using System.Collections.Generic;
using MVCDemo.Models;

namespace MVCDemo
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}

