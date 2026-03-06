using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class OrderData
    {
        public static readonly List<Order> Order = new List<Order>
        {
          new Order()
          {
              Id = 1,
              ClientId = 1,
              ProductId = 1,
              Amount = 14,
          },
          new Order()
          {
              Id = 2,
              ClientId = 2,
              ProductId = 2,
              Amount = 30,
          },
          new Order()
          {
              Id = 3,
              ClientId = 3,
              ProductId = 3,
              Amount = 2,
          },
          new Order()
          {
              Id = 4,
              ClientId = 4,
              ProductId = 4,
              Amount = 16,
          },
          new Order()
          {
              Id = 5,
              ClientId = 5,
              ProductId = 5,
              Amount = 12,
          },
          new Order()
          {
              Id = 6,
              ClientId = 3,
              ProductId = 6,
              Amount = 87,
          },
          new Order()
          {
              Id = 7,
              ClientId = 1,
              ProductId = 7,
              Amount = 55,
          },
          new Order()
          {
              Id = 8,
              ClientId = 1,
              ProductId = 8,
              Amount = 4,
          },
          new Order()
          {
              Id = 9,
              ClientId = 4,
              ProductId = 9,
              Amount = 5,
          },
          new Order()
          {
              Id = 10,
              ClientId = 5,
              ProductId = 10,
              Amount = 3,
          },
        };
    }
}
