using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Order
    {
        public List<Hashtable> get(int OrderID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Orders
                      where a.OrderID == OrderID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("OrderID", item.OrderID);
                data.Add("ShowID", item.ShowID);
                data.Add("TotalPrice", item.TotalPrice;
                data.Add("Status", item.Status);

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