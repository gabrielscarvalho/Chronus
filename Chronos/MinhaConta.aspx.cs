using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chronos
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nome = Convert.ToString(Session["user.name"]);

            int id = Convert.ToInt32(Session["user.id"]);
            if (id != 0)
            {
                Model.Orm.Usuario user = new Model.Orm.Usuario();

                user.load(id);

                if (user.exists())
                {

                    lblUserName.Text = user.getNome();
                }
                else
                {
                    Response.Redirect("Register.aspx");
                }

            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }
    }
}