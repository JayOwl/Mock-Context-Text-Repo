using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockContextTestRepoClass.Repo
{
    public class ProductRepository
    {
        // The constructor allows us to pass in the mock context.
        private JB_FoodStoreEntities context = new JB_FoodStoreEntities();
        public ProductRepository(JB_FoodStoreEntities context)
        {
            this.context = context;
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProduct(int productID)
        {
            return context.Products.Where(p => p.productID == productID)
                          .FirstOrDefault();
        }

    }
}