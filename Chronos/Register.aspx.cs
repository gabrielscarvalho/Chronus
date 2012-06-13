using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Chronos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {



            Model.Db db = new Model.Db();

            DataRow[] users = db.select("SELECT * FROM Usuario;");
            //foreach(DataRow us in users){

            db.insert("INSERT INTO usuario (usu_id, usu_nome,usu_email, usu_senha) values(3, 'Gabriel','gabriel@hotmail.com','senha123') RETURNING usu_id ");
            


        }

    }
}