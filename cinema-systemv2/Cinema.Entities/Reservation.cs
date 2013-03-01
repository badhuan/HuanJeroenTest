using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Reservation
    {
        public List<Hashtable> get(int ReservationID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Reservations
                      where a.ReservationID == ReservationID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("ReservationID", item.ReservationID);
                data.Add("CustomerID", item.CustomerID);
                data.Add("OrderID", item.OrderID);
                data.Add("ReservationTime", item.ReservationTime);

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