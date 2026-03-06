using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ClientData
    {
        public static readonly List<Client> Client = new List<Client>
        {
          new Client()
          {
              Id = 1,
              Name = "Liina",
              City = "Tallinn"

          },
          new Client()
          {
              Id = 2,
              Name = "Peeter",
              City = "Tatru"

          },
          new Client()
          {
              Id = 3,
              Name = "Ronna",
              City = "Narva"
          },
          new Client()
          {
              Id = 4,
              Name = "Mari",
              City = "Tallinn"
          },
          new Client()
          {
              Id = 5,
              Name = "Jaak",
              City = "Pärnu"
          },
        };
    }
}
