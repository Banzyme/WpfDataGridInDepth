using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeculiaWPFDataGridInDepth.Data
{
    public static class DataService
    {
        private static List<Person> clients = new List<Person>();

        public static List<Person> GetAllclients()
        {
            var Orders1 = new List<Order>()
            {
                new Order(){Id=1 , Status = ORDER_STATUS.CREATED, OrderDescription ="Return not completed" },
                new Order(){Id=2 , Status = ORDER_STATUS.IN_PROGRESS, OrderDescription ="Supporting docs outstanding" },
                new Order(){Id=3 , Status = ORDER_STATUS.COMPLETED, OrderDescription ="Potential fraud" }
            };
            clients.Add(new Person()
            {
                Id = 1,
                Firstname = "Mike",
                Lastname = "Start",
                Gender = GENDER.MALE,
                Orders = Orders1,
                BirthPlace = "USA",
                Adress = new Address() { Place = "Montana", StreeNo = 810 }
            }) ;


            var Orders2 = new List<Order>()
            {
                new Order(){Id=1 , Status = ORDER_STATUS.CREATED, OrderDescription ="Return not completed" },
                new Order(){Id=2 , Status = ORDER_STATUS.IN_PROGRESS, OrderDescription ="Supporting docs outstanding" },
                new Order(){Id=3 , Status = ORDER_STATUS.COMPLETED, OrderDescription ="Potential fraud" }
            };
            clients.Add(new Person()
            {
                Id = 1,
                Firstname = "Sahron",
                Lastname = "Meyer",
                Gender = GENDER.FEMALE,
                BirthPlace = "USA",
                Orders = Orders2,
                Adress = new Address() { Place = "Hatfield", StreeNo = 810 }
            });


            var Orders3 = new List<Order>()
            {
                new Order(){Id=1 , Status = ORDER_STATUS.CREATED, OrderDescription ="Return not completed" },
                new Order(){Id=2 , Status = ORDER_STATUS.IN_PROGRESS, OrderDescription ="Supporting docs outstanding" },
                new Order(){Id=3 , Status = ORDER_STATUS.COMPLETED, OrderDescription ="Potential fraud" }
            };
            clients.Add(new Person()
            {
                Id = 1,
                Firstname = "ENDEE",
                Lastname = "Sa",
                Gender = GENDER.FEMALE,
                BirthPlace = "RSA",
                Orders = Orders3,
                Adress = new Address() { Place = "New york", StreeNo = 810 }
            });






            return clients;
        }


    }
}
