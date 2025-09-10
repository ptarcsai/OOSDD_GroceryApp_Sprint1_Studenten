using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = new() //Initialized list with 4 new products
            {
                new Product(1, "Melk", 300),  
                new Product(2, "Kaas", 100),
                new Product(3,"Brood", 400),
                new Product(4, "Cornflakes", 0)

            };
        }
        public List<Product> GetAll()
        {
            return products; //Changed to list name so it returns something (of course products in this case
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
