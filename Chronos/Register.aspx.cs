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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(txtNascimento.Text);
           

            Model.Orm.Usuario apessoa = new Model.Orm.Usuario();
            bool salvar = true;
            

            if (txtEmail.Text != txtEmail2.Text)
            {
                lblEmail.Text = "* Seu email não confere. Digite o email correto!";
                lblEmail.Visible = true;
                txtEmail2.Text = "";
                salvar = false;
            }


            if (txtPassword.Text != txtPassword2.Text)
            {
                lblSenha.Text = "* Sua senha não confere. Digite a senha correta!";
                lblSenha.Visible = true;
                salvar = false;
            }

            if (salvar == true)
            {
                apessoa.setNome(txtNome.Text);
                apessoa.setSobrenome(txtSobrenome.Text);
                apessoa.setSexo(txtSexo.SelectedValue);
                apessoa.setNascimento(data.Year + "-" + data.Month + "-" + data.Day);
                apessoa.setEmail(txtEmail.Text);
                apessoa.setStatus("A");
                apessoa.setSenha(txtPassword.Text);
                apessoa.save();
                Response.Redirect("MinhaConta.aspx");
                Session["user.name"] = apessoa.getNome();
                Session["user.id"] = apessoa.getId();
            }
        }

    }
}