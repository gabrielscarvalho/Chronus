using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Chronos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {


            string table;
            
            Model.Db db = new Model.Db();

            DataRow[] tags = db.select("SELECT * FROM tag;");

            //int a = db.insert("INSERT into tag (tag) VALUES ('tagaghiurae');");

            Model.Data field = new Model.Data();

            field.setData("nome","Jose");
            field.setData("sobrenome", "Silva");
            field.setData("email", "josesilva@gmail.com");
            field.setData("senha", "12342");
            
            field.setData("status", "1");
            

            table = "usuario";

            int userId = db.insertCommand(field.getCollectedData(), table);

      

        }

    }
}