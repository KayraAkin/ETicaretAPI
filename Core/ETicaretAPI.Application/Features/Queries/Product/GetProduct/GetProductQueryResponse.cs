﻿using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Product.GetProduct
{
    public class GetProductQueryResponse
    {
        public Domain.Entities.Product Product { get; set; }
    }
}