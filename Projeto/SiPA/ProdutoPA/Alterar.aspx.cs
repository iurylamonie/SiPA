using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.ProdutoPA
{
    public partial class Alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBoxId.Text = Session["prd-id"].ToString();
                TextBoxDescricao.Text = Session["prd-descricao"].ToString();
            }
           
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProdutoPA/Listar.aspx");
        }

        protected void ButtonAlterar_Click(object sender, EventArgs e)
        {
            SiPA.Produto produto = new Produto { id = int.Parse(TextBoxId.Text), descricao = TextBoxDescricao.Text };
            Modelo.Produto.Alterar(produto);
            Response.Redirect("~/ProdutoPA/Listar.aspx");
        }
    }
}