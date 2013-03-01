using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class LookWiser
    {
        public List<Hashtable> get(int LookWiserID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.LookWisers
                      where a.LookWiserID == LookWiserID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("LookWiserID", item.LookWiserID);
                data.Add("Title", item.Title);
                data.Add("Pictogram", item.Pictogram);
                data.Add("Description", item.Description);

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