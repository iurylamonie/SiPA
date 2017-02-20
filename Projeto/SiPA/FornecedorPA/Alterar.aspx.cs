using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiPA.FornecedorPA
{
    public partial class Alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SiPA.Fornecedor fornecedor = Modelo.Fornecedor.CosultarPorId(int.Parse(Session["for-id"].ToString()));
                TextBoxId.Text = fornecedor.id.ToString();
                TextBoxNome.Text = fornecedor.nome;
                TextBoxTelefone.Text = fornecedor.telefone;
                TextBoxCidade.Text = fornecedor.cidade;
                TextBoxEstado.Text = fornecedor.estado;
                TextBoxEndereço.Text = fornecedor.endereco;
                TextBoxEmail.Text = fornecedor.email;
                if (fornecedor.opCPForCNPJ == 1)
                {
                    TextBoxCPFCNPJ.Text = fornecedor.cpf;
                    RadioButtonList1.SelectedIndex = 0;
                }
                else if (fornecedor.opCPForCNPJ == 2)
                {
                    TextBoxCPFCNPJ.Text = fornecedor.cnpj;
                    RadioButtonList1.SelectedIndex = 1;
                }
            }
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FornecedorPA/Listar.aspx");
        }

        protected void ButtonAlterar_Click(object sender, EventArgs e)
        {
            SiPA.Fornecedor fornecedor = new Fornecedor
            {
                id = int.Parse(TextBoxId.Text),
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
            Modelo.Fornecedor.Alterar(fornecedor);
            Response.Redirect("~/FornecedorPA/Listar.aspx");
        }
    }
}