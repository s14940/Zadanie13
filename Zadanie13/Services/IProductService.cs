using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie13.Models;

namespace Zadanie13.Services
{
    public class IProductService
    {
        public List<WyrobCukierniczy> GetAllProducts(List<ProductRequest> list);
    }
}
