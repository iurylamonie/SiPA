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
        private SiPA.Compra compra;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LabelData.Text = DateTime.Now.Date.ToString();
            }
        }

        protected void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            
            try
            {
                compra = new Compra
                {
                    fornecedor_id = int.Parse(DropDownListFornecedor.SelectedValue.ToString()),
                    dataCompra = DateTime.Now.Date,

                };
                Modelo.Compra.Incluir(compra);
                compra = Modelo.Compra.RetornarUltima();

                DropDownListFornecedor.Enabled = false;

                Label3.Visible = true;
                Label4.Visible = true;
                DropDownListProdutos.Visible = true;
                Label5.Visible = true;
                TextBoxUnidade.Visible = true;
                Label6.Visible = true;
                TextBoxQuantidade.Visible = true;
                Label7.Visible = true;
                TextBoxPrecoUnitario.Visible = true;
                Label8.Visible = true;
                TextBoxValorTotal.Visible = true;
                ButtonIncluir.Visible = true;
                GridViewItens.Visible = true;
                Label9.Visible = true;
                TextBoxDesconto.Visible = true;
                Label10.Visible = true;
                TextBoxValorTotalCompra.Visible = true;
                ButtonGravar.Visible = true;
                ButtonCancelar.Visible = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ButtonCancelarCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CompraPA/Listar.aspx");
        }
    }
}