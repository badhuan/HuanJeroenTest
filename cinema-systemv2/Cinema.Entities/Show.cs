using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Show
    {
        public List<Hashtable> get(int ShowID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Shows
                      where a.ShowID == ShowID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("ShowID", item.ShowID);
                data.Add("RoomID", item.RoomID);
                data.Add("MovieID", item.MovieID);
                data.Add("Time", item.Time);
                data.Add("SeatType", item.SeatType);
                data.Add("TicketPrice", item.TicketPrice);

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