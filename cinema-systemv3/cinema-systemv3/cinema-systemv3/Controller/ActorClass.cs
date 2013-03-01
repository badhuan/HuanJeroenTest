using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cinema_systemv3.Presentation; 

namespace cinema_systemv3
{
    public class ActorClass
    {
        static DataClasses1DataContext datacontext = new DataClasses1DataContext();

        public static object SelectAllActor()
        {
            var query = from actor in datacontext.Actors
                        select new { actor};
            return query;
        }

        public void Insert(Actor actor)
        {
            datacontext.Actors.InsertOnSubmit(actor);
            try
            {
                datacontext.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Kon niet toevoegen.");
            }
        }

        public object SelectOne(int actorIDinput)
        {
            var selectActor = (from actor in datacontext.Actors
                               where actor.ActorID == actorIDinput
                                   select actor);
            return selectActor;
        }
    }
}