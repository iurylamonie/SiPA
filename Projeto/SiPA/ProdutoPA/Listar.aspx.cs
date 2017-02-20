using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.ProdutoPA
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProdutoPA/Incluir.aspx");
        }

        protected void ButtonAtualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProdutoPA/Listar.aspx");
        }

        protected void GridViewProduto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Alterar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Session["prd-id"] = GridViewProduto.Rows[index].Cells[0].Text;
                Session["prd-descricao"] = GridViewProduto.Rows[index].Cells[1].Text.ToString(); ;
                Response.Redirect("~/ProdutoPA/Alterar.aspx");
            }
            else if (e.CommandName == "Excluir")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                int idProduto = int.Parse(GridViewProduto.Rows[index].Cells[0].Text);
                Modelo.Produto.Excluir(idProduto);
                Response.Redirect("~/ProdutoPA/Listar.aspx");
            }
        }
    }
}