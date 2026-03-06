using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ProductData
    {
        public static readonly List<Product> Product = new List<Product>
        {
          new Product()
          {
              Id = 1,
              Name = "Kala",
              Category = "toit",
              Price = 12.99,
              Amount = 40,
          },
                    new Product()
          {
              Id = 2,
              Name = "Heeringas(purgis)",
              Category = "toit",
              Price = 5.99,
              Amount = 201,
          },
          new Product()
          {
              Id = 3,
              Name = "Kana",
              Category = "toit",
              Price = 9.99,
              Amount = 31,
          },
          new Product()
          {
              Id = 4,
              Name = "Kana koivad",
              Category = "toit",
              Price = 8.98,
              Amount = 444,
          },
          new Product()
          {
              Id = 5,
              Name = "tolmuimeja",
              Category = "Kodu masinad",
              Price = 499.99,
              Amount = 511,
          },
          new Product()
          {
              Id = 6,
              Name = "Kana(Elus)",
              Category = "Koduloomad",
              Price = 21.99,
              Amount = 5000,
          },
          new Product()
          {
              Id = 7,
              Name = "jõehobu(Elus)",
              Category = "Koduloomad",
              Price = 199.99,
              Amount = 67,
          },
          new Product()
          {
              Id = 8,
              Name = "kosmoselaev pro max JSKW-8374",
              Category = "Teaduselised esemed",
              Price = 50000000,
              Amount = 1,
          },
          new Product()
          {
              Id = 9,
              Name = "Ülemiste Keskus",
              Category = "Ehitised",
              Price = 500000,
              Amount = 1,
          },          
            new Product()
          {
              Id = 10,
              Name = "Lennujaam",
              Category = "Ehitised",
              Price = 100000000,
              Amount = 1,
          },
        };
    }
}
