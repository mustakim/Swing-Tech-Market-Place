using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Entity.Database_Entity;

namespace MarketPlace.Context
{
    public class ProductContext 
    {
        

        public List<Product> GetAllProducts()
        {
            using (var context = new DatabaseContext())
            {
                return (from product in context.Products select product).ToList();
                //can return null if No Product found
            }
        }


        public List<Product> GetAllProductsByCatagory(string catagory)
        {
            using (var context = new DatabaseContext())
            {
                return (from products in context.Products where products.Catagory==catagory select products).ToList();
                //can return null if No Product found
            }
        }

     

        public bool UpdateProduct (Product oldProduct, Product newProduct)
        {
            //Takes a Old product Object and new product object and Updates New informations Returns true if successful

            using (var context = new DatabaseContext())
            {
                try
                {
                    var Product = (from product in context.Products where product.Sl == oldProduct.Sl select product).FirstOrDefault();
                    if (Product == null) return false;
                    Product.Name = newProduct.Name;
                    Product.Catagory = newProduct.Catagory;
                    Product.BuyingPrice = newProduct.BuyingPrice;
                    Product.Color = newProduct.Color;
                    Product.Id = newProduct.Id;
                    Product.SellingPrice = newProduct.SellingPrice;
                    Product.Quantity = newProduct.Quantity;
                    Product.Tag = newProduct.Tag;
                    context.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }


            }
        }

        public bool AddNewProduct(Product product)
        {
            //Takes An product Object as Parameter returns true if Database is updated
            using (var context = new DatabaseContext())
            {
                try
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        public bool RemoveProduct(Product product)
        {
            //Takes An Product Object as Parameter returns true if Product is Removed from database and Saved
            using (var context = new DatabaseContext())
            {
                try
                {
                    
                    Product item = context.Set<Product>().FirstOrDefault(r => r.Sl == product.Sl);
                    if (item == null) return false;
                    context.Products.Remove(item);
                    context.SaveChanges();
                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }
        }






    }
}
