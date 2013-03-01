using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Customer
    {
        public List<Hashtable> get(int CustomerID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Customers
                      where a.DiscountID == CustomerID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("CustomerID", item.CustomerID);
                data.Add("Firstname", item.Firstname);
                data.Add("Insertion", item.Insertion);
                data.Add("Lastname", item.Lastname);
                data.Add("Date_Of_Birth", item.Date_Of_Birth);
                data.Add("Sex", item.Sex);
                data.Add("Zipcode", item.Zipcode);
                data.Add("Street", item.Street);
                data.Add("Street_Number", item.Street_Number);
                data.Add("Email", item.Email);
                data.Add("Password", item.Password);

                lijst.Add(data);
            }

            return lijst;
        }

        public void insert()
        {
        }
        public void update()
        {
        }
        public void delete()
        {
        }
        public void selectAll()
        {
        }
    }
}