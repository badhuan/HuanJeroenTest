using System.Collections.Generic;
using Cinema.DataStorage;
using System.Collections;

namespace Cinema.Entities
{
    public class Actor
    {
        DatabaseDataContext db = new DatabaseDataContext();
   
        public List<Hashtable> get(int ActorID)
        {
               var query = from actor in db.Actors
                        where actor.ActorID == ActorID
                        select actor;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in query)
            {

                Hashtable data = new Hashtable();
                data.Add("ActorID", item.ActorID);
                data.Add("Name", item.Name);

                lijst.Add(data);
            }

            return lijst;
        }

        public void insert(Actor Name)
        {
            db.Actors.InsertOnSubmit(Name);
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