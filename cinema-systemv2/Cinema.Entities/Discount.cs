using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Discount
    {

        public List<Hashtable> get(int DiscountID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Discounts
                      where a.DiscountID == DiscountID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("DiscountID", item.DiscountID);
                data.Add("Title", item.Title);
                data.Add("Description", item.Description);
                data.Add("Discount", item.Discount);

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