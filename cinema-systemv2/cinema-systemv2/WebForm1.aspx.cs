using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinema_systemv2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestDBDataContext db = new TestDBDataContext();
            var qry = from a in db.Actors
                      //where m.ActorID == 3
                      //select m;
                      select a;

            List<Hashtable> lijst =  new List<Hashtable>();
            foreach (var item in qry)
            {

                Hashtable data = new Hashtable();
                data.Add("ActorID", item.ActorID);
                data.Add("Name", item.Name);

                lijst.Add(data);

             }


            foreach (Hashtable t in lijst)
            {
                foreach (DictionaryEntry entry in t)
                {
                    System.Diagnostics.Debug.WriteLine(entry.Key + " " + entry.Value); 
                }
            }


            ////Uiatleazen van data hoeven we eigenlijk toch
            // niet veel testc doen ArgumentOutOfRangeException wel ??
            
        }
    }
}
