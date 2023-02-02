﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi2TableClient.Models;
using System.Threading.Tasks;

namespace WebApi2TableClient.Repository
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        void Remove(int id);
        bool Update(Product item);
    }
}
