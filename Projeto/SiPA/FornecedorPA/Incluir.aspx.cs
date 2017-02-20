using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.FornecedorPA
{
    public partial class Incluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FornecedorPA/Listar.aspx");
        }

        protected void ButtonIncluir_Click(object sender, EventArgs e)
        {
            SiPA.Fornecedor fornecedor = new Fornecedor
            {
                nome = TextBoxNome.Text,
                telefone = TextBoxTelefone.Text,
                cidade = TextBoxCidade.Text,
                estado = TextBoxEstado.Text,
                endereco = TextBoxEndereço.Text,
                email = TextBoxEmail.Text,                
            };
            if (RadioButtonList1.SelectedValue == "CPF")
            {
                fornecedor.cpf = TextBoxCPFCNPJ.Text;
                fornecedor.opCPForCNPJ = 1;
            }
            else if (RadioButtonList1.SelectedValue == "CNPJ")
            {
                fornecedor.cnpj = TextBoxCPFCNPJ.Text;
                fornecedor.opCPForCNPJ = 2;
            }
            Modelo.Fornecedor.Incluir(fornecedor);
            Response.Redirect("~/FornecedorPA/Listar.aspx");
        }
    }
}