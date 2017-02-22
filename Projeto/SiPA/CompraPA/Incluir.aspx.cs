using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.CompraPA
{
    public partial class Incluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LabelData.Text = DateTime.Now.Date.ToString();
            }
        }

        protected void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            SiPA.Compra compra = new Compra
                {
                    fornecedor_id = int.Parse(DropDownListFornecedor.SelectedValue.ToString()),
                    dataCompra = DateTime.Now.Date,

                };
                Modelo.Compra.Incluir(compra);
                compra = Modelo.Compra.RetornarUltima();
            Session["com-id"] = compra.id;
            Response.Redirect("~/CompraPA/AdicionarItens.aspx");
    }

        protected void ButtonCancelarCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CompraPA/Listar.aspx");
        }
    }
}