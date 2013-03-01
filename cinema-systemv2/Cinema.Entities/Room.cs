using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Room
    {
        public List<Hashtable> get(int RoomID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Rooms
                      where a.RoomID == RoomID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("RoomID", item.RoomID);
                data.Add("SeatsPerRow", item.SeatsPerRow);
                data.Add("Rows", item.Rows);

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