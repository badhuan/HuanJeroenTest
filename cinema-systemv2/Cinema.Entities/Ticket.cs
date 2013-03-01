using System.Collections.Generic;
using Cinema.DataStorage;
using System.Collections;


namespace Cinema.Entities
{
    public class Ticket
    {
        public List<Hashtable> get(int TicketID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Tickets
                      where a.TicketID == TicketID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("TicketID", item.TicketID);
                data.Add("SeatNr", item.SeatNr);
                data.Add("Price", item.Price);
                data.Add("DiscountID", item.DiscountID);
                data.Add("OrderID", item.OrderID);

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