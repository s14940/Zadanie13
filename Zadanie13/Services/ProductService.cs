using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie13.Models;


namespace Zadanie13.Services
{
    public class ProductService : IProductService
    {
        private readonly CukierniaContext _context;

        public ProductService(CukierniaContext context)
        {
            _context = context;
        }


        public List<WyrobCukierniczy> GetAllProducts(List<ProductRequest> list)
        {
            List<WyrobCukierniczy> result = new List<WyrobCukierniczy>();

            foreach (var entry in list)
            {
                var product = _context.WyrobCukierniczy.Where(w => w.Nazwa == entry.Product)?.First();

                if (null != product)
                {
                    result.Add(product);
                }
                else
                {
                    throw new Exception();
                }
            }

            return result;
        }
    }

    public class ProductRequest
    {
    }
}
