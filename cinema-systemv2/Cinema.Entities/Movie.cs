using Cinema.DataStorage;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Entities
{
    public class Movie
    {
        public List<Hashtable> get(int MovieID)
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var qry = from a in db.Movies
                      where a.MovieID == MovieID
                      select a;

            List<Hashtable> lijst = new List<Hashtable>();
            foreach (var item in qry)
            {
                Hashtable data = new Hashtable();
                data.Add("MovieID", item.MovieID);
                data.Add("Title", item.Title);
                data.Add("Description", item.Description);
                data.Add("Director", item.Director);
                data.Add("Poster", item.Poster);
                data.Add("Trailer", item.Trailer);
                data.Add("Genre", item.Genre);
                data.Add("Duration", item.Duration);

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