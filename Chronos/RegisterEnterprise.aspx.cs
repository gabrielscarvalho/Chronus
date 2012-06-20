using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chronos
{
    public partial class RegisterEnterprise : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Model.Orm.Empresa empresa = new Model.Orm.Empresa();
            empresa.setNome(txtRazao.Text);
           
        }

        protected void txtNome_TextChanged(object sender, EventArgs e)
        {

        }   
    }
}