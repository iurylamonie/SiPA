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
    }
}