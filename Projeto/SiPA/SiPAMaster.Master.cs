using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA
{
    public partial class SiPAMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProdutoPA/Listar.aspx");
        }

        protected void ButtonFornecedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FornecedorPA/Listar.aspx");
        }

        protected void ButtonCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CompraPA/Listar.aspx");
        }
    }
}