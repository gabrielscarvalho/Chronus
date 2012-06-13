using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;


namespace Chronos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {



            Model.Orm.Usuario usuario = new Model.Orm.Usuario();
            usuario.load(5);

            if (usuario.exists())
            {
                Console.WriteLine("O usuario: " + usuario.getNome() + " existe!! ");
            }
            else
            {
                Console.WriteLine("Usuário não existe.");
            }

            //string table;

            /*
            Model.Db db = new Model.Db();
            string nome;
            DataRow[] usuarios = db.select("SELECT * FROM usuario where id= 5;");

            if (usuarios.Length == 0)
            {
                int i = 4;
            }else{
                int x = 5;
            }

            string[] columns = db.__getColumnsLastSelect();
            foreach (DataRow us in usuarios)
            {
                foreach (string columnName in columns)
                {
                    nome = Convert.ToString(us[columnName]);
                }
            }
            */

            /*Model.Orm.Usuario usuario = new Model.Orm.Usuario();

            usuario.setNome("José")
                .setSobrenome("Silva")
                .setEmail("jose.silva23@gmail.com")
                .setSenha("senha1412")
                .setStatus("1")
                .save();
            

            
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

      
            */
        }

    }
}