using System;
using System.Collections.Generic;


namespace MVC
{
    public class ProductModel
    {
        public static void GenerateDB()
        {
            var context = new ProductContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            List<Product> products = new List<Product>();
            for(int i=0; i< 10; i++)
            {
                Product product = new Product
                {
                    Name = "Product" + i,
                    Categorie = "Cat" + i
                };
                products.Add(product);
            }
            context.AddRange(products);
            context.SaveChanges();
        }



    }
}
