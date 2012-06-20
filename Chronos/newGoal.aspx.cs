using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Chronos
{
    public partial class newGoal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void enviaImagem(object sender, EventArgs e)
        {
        }

        protected void addGoal_Click(object sender, EventArgs e)
        {
            Model.Orm.Objetivo objetivo = new Model.Orm.Objetivo();
            objetivo.setTitulo(txtTitulo.Text);
            objetivo.setDescricao(txtDescricao.Text);
            objetivo.setIniciadoEm(txtInicio.Text);
            objetivo.save();

            Model.Orm.Meta newGoal = new Model.Orm.Meta();
            newGoal.setTitulo(txtMeta.Text);
            newGoal.setFinalizarEm(txtDataPrevista.Text);
            newGoal.save();
        }


    }
}