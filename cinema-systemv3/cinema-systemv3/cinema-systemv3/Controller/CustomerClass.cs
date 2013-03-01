using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cinema_systemv3.Presentation;

namespace cinema_systemv3
{
    public class CustomerClass
    {
        static DataClasses1DataContext datacontext = new DataClasses1DataContext();

        public static object SelectAllCustomer()
        {
            var query = from customer in datacontext.Actors
                        select new { customer };
            return query;
        }

        public void Insert(Customer customer)
        {
            datacontext.Customers.InsertOnSubmit(customer);
            try
            {
                datacontext.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Kon niet toevoegen.");
            }
        }
    }
}