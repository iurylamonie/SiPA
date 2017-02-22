using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.CompraPA
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["esp-fornecedor"] = 1;
            Session["esp-periodo"] = null;
        }

        protected void RadioButtonListEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonListEscolha.SelectedValue.ToString() == "Todos")
            {
                DropDownListFornecedores.Enabled = false;
            }
            else if (RadioButtonListEscolha.SelectedValue.ToString() == "Especifico")
            {
                DropDownListFornecedores.Enabled = true;
            }

        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CompraPA/Incluir.aspx");
        }

        protected void GridViewCompras_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Selecionar")
            {

            }
            else if (e.CommandName == "Alterar")
            {

            }
            else if (e.CommandName == "Excluir")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                int idcompra = int.Parse(GridViewCompras.Rows[index].Cells[0].Text);
                Modelo.Compra.Excluir(idcompra);
                Response.Redirect("~/CompraPA/Listar.aspx");
            }
        }

        protected void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            if (RadioButtonListEscolha.SelectedValue.ToString() == "Todos")
            {
                GridViewCompras.Visible = true;
                GridViewCompras.DataSourceID = "ObjectDataSourceCompras";

            }
            else if (RadioButtonListEscolha.SelectedValue.ToString() == "Especifico")
            {
                GridViewCompras.Visible = true;
                GridViewCompras.DataSourceID = "ObjectDataSourceComprasEspecifica";
                Session["esp-fornecedor"] = DropDownListFornecedores.SelectedItem;
                Session["esp-periodo"] = CalendarPeridodo.SelectedDate;
            }
            else
            {
                GridViewCompras.Visible = true;
                GridViewCompras.DataSourceID = "ObjectDataSourceCompras";
            }
        }
    }
}