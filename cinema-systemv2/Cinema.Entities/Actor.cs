using System.Collections.Generic;
using Cinema.DataStorage;
using System.Collections;

namespace Cinema.Entities
{
    public class Actor
    {

        public List<Hashtable> get(int ActorID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Actors
                      where a.ActorID == ActorID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {

                Hashtable data = new Hashtable();
                data.Add("ActorID", item.ActorID);
                data.Add("Name", item.Name);

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