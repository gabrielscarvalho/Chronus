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
                 usuario.setNome("Joao Alterado");
                 int id =  usuario.save();
            }
            else
            {
                Console.WriteLine("Usuário não existe.");
            }

           

            

            /*
            
            Model.Db db = new Model.Db();
            Model.Data field = new Model.Data();

            field.setData("nome", "Gabriel Alterado");
            field.setData("sobrenome", "Silva");
            field.setData("email", "josesilva@gmail.com");
            field.setData("senha", "12342");

            field.setData("status", "1");


            string table = "usuario";

            bool userId = db.updateCommand(field.getCollectedData(), table," id = 5");

           
            DataRow usuario = db.fetchRow("SELECT * FROM usuario;");

            if (usuario != null)
            {
                string nome = Convert.ToString(usuario["nome"]);
            }
            

            */
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(txtNascimento.Text);
           

            Model.Orm.Usuario apessoa = new Model.Orm.Usuario();

            apessoa.setNome(txtNome.Text);
            apessoa.setSobrenome(txtSobrenome.Text);
            apessoa.setSexo(txtSexo.SelectedValue);
            apessoa.setNascimento(data.Year+"-"+data.Month+"-"+data.Day);
            apessoa.setEmail(txtEmail.Text);
            apessoa.setSenha(txtPassword.Text);


            apessoa.save();

           


            if (txtEmail.Text != txtEmail2.Text)
                lblEmail.Text = "* Seu email não confere. Digite o email correto!";
                lblEmail.Visible = true;
                txtEmail2.Text = "";



            if (txtPassword.Text != txtPassword2.Text)
                lblSenha.Text = "* Sua senha não confere. Digite a senha correta!";
                lblSenha.Visible = true;
        }

    }
}