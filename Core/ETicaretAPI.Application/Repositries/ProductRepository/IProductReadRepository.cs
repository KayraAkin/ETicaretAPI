﻿using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositries.ProductRepository
{
    public interface IProductReadRepository : IReadRepository<Product>
    {
    }
}
