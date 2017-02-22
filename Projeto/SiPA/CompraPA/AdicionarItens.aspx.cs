using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.CompraPA
{
    public partial class AdicionarItens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelCompraId.Text = Session["com-id"].ToString();
            TextBoxValorTotal.Text = Modelo.Compra.valorTotalCompra.ToString();
        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            SiPA.ItemCompra ic = new ItemCompra
            {
                produto_id = int.Parse(DropDownListProdutos.SelectedValue.ToString()),
                compra_id = int.Parse(Session["com-id"].ToString()),
                unidade = TextBoxUnidade.Text,
                quantidade = double.Parse(TextBoxQuantidade.Text),
                precoUnitario =  double.Parse(TextBoxPrecoUnitario.Text),
                valorTotal = double.Parse(TextBoxQuantidade.Text) * double.Parse(TextBoxPrecoUnitario.Text)
            };

            Modelo.Compra.valorTotalCompra += (double) ic.valorTotal;
            TextBoxValorTotal.Text = Modelo.Compra.valorTotalCompra.ToString(); ;
            Modelo.ItemCompra.Incluir(ic);

            TextBoxUnidade.Text = null;
            TextBoxQuantidade.Text = null;
            TextBoxPrecoUnitario.Text = null;
            TextBoxValorTotal.Text = null;

            Response.Redirect("~/CompraPA/AdicionarItens.aspx");
        }

        protected void ButtonGravar_Click(object sender, EventArgs e)
        {
            SiPA.Compra compra = Modelo.Compra.RetornarUltima();
            compra.valorTotal = Modelo.Compra.valorTotalCompra;
            Modelo.Compra.Alterar(compra);
            Session["com-id"] = null;
            Modelo.Compra.valorTotalCompra = 0;
            Response.Redirect("~/CompraPA/Listar.aspx");           
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Modelo.Compra.Excluir(int.Parse(Session["com-id"].ToString()));
            Session["com-id"] = null;
            Modelo.Compra.valorTotalCompra = 0;
            Response.Redirect("~/CompraPA/Listar.aspx");
        }

        protected void GridViewItens_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Remover")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                int item_id = int.Parse(GridViewItens.Rows[index].Cells[0].Text);
                double valorTotalItem = double.Parse(GridViewItens.Rows[index].Cells[5].Text);
                Modelo.Compra.valorTotalCompra -= valorTotalItem;
                Modelo.ItemCompra.Remover(item_id);                
                Response.Redirect("~/CompraPA/AdicionarItens.aspx");
            }
        }
    }
}