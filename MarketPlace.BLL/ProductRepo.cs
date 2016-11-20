using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Context;
using MarketPlace.Entity.Database_Entity;

namespace MarketPlace.BLL
{
    public class ProductRepo
    {
        public List<Product> GetAllProducts()
        {
            return new ProductContext().GetAllProducts();
            //yes it works as the name
        }

        public List<Product> GetProductsByCatagorg(string catagory)
        {
            return new ProductContext().GetAllProductsByCatagory(catagory);
            //Read the name
        }


        public bool AddNewProduct(Product product)
        {
            return new ProductContext().AddNewProduct(product);
            //again read name
        }

        public bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            return new ProductContext().UpdateProduct(oldProduct, newProduct);
            //Updates the old product with the new one and returns true if successful
        }

        public bool RemoveProduct(Product product)
        {
            return new ProductContext().RemoveProduct(product);
            //Removes the given product
        }



    }
}
