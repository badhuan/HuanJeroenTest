using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinema_systemv3.Presentation
{
    public partial class ActorUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBoxActor.Text != String.Empty)
            {
                Actor newActor = new Actor();
                newActor.Name = TextBoxActor.Text;
                ActorClass actorClasse = new ActorClass();
                actorClasse.Insert(newActor);
                Response.Redirect(Request.RawUrl, true);
            }
            else
            {
                Response.Write("Veld is leeg.");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                        if (TextBoxActorID.Text != String.Empty)
            {
                Actor newActor = new Actor();
                ActorClass actorClasse = new ActorClass();
                int test;
                test = int.Parse(TextBoxActorID.Text);
                actorClasse.SelectOne(test);
            }
            else
            {
                Response.Write("ID is leeg of bestaat niet.");
            }
        }


    }
}