using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.ProdutoPA
{
    public partial class Incluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProdutoPA/Listar.aspx");
        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            SiPA.Produto produto = new Produto { descricao = TextBoxDescricao.Text };
            Modelo.Produto.Incluir(produto);
            Response.Redirect("~/ProdutoPA/Listar.aspx");
        }
    }
}