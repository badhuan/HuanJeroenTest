using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Coupon
    {

        public List<Hashtable> get(int DiscountCode)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Coupons
                      where a.DiscountCode == DiscountCode
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("DiscountCode", item.DiscountCode);
                data.Add("OrderID", item.OrderID);
                data.Add("CustomerID", item.CustomerID);
                data.Add("Discount", item.Discount);
                data.Add("Multiple_Use", item.Multiple_Use);
                data.Add("Activated", item.Activated);

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