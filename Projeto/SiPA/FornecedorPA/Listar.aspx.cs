using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.FornecedorPA
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewFornecedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Selecionar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                int fornecedorId = int.Parse(GridViewFornecedores.Rows[index].Cells[0].Text);
                SiPA.Fornecedor fornecedor = Modelo.Fornecedor.CosultarPorId(fornecedorId);
                LabelCidade.Text = fornecedor.cidade;
                LabelEmail.Text = fornecedor.email;
                LabelEndereco.Text = fornecedor.endereco;
                if (fornecedor.opCPForCNPJ == 1)
                {
                    LabelCPFCNPJ.Text = fornecedor.cpf;
                }
                else if (fornecedor.opCPForCNPJ == 2)
                {
                    LabelCPFCNPJ.Text = fornecedor.cnpj;
                }

            }
            else if (e.CommandName == "Alterar")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                Session["for-id"] = GridViewFornecedores.Rows[index].Cells[0].Text;
                Response.Redirect("~/FornecedorPA/Alterar.aspx");
            }
            else if (e.CommandName == "Excluir")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                int fornecedorId = int.Parse(GridViewFornecedores.Rows[index].Cells[0].Text);
                Modelo.Fornecedor.Excluir(fornecedorId);
                Response.Redirect("~/FornecedorPA/Listar.aspx");
            }
        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FornecedorPA/Incluir.aspx");
        }
    }
}