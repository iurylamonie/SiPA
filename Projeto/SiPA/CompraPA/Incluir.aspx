<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Incluir.aspx.cs" Inherits="SiPA.CompraPA.Incluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" text="Fornecedor" />
        <asp:DropDownList ID="DropDownListFornecedor" runat="server" DataSourceID="ObjectDataSourceFornecedores" DataTextField="nome" DataValueField="id" />
        <asp:ObjectDataSource ID="ObjectDataSourceFornecedores" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Fornecedor"></asp:ObjectDataSource>
        <asp:Label ID="Label2" runat="server" text="Data" />
        <asp:Label ID="LabelData" runat="server" />

        <asp:Button ID="ButtonConfirmar" runat="server" Text="Confirmar" OnClick="ButtonConfirmar_Click" />
        <asp:Button ID="ButtonCancelarCompra" runat="server" Text="Cancelar" OnClick="ButtonCancelarCompra_Click" />
    </div>

    <div>
        <asp:Label ID="Label3" runat="server" text="ITENS DA COMPRA" Visible="false" /><br />
        <asp:Label ID="Label4" runat="server" text="Produto" Visible="false" />
        <asp:DropDownList ID="DropDownListProdutos" runat="server" DataSourceID="ObjectDataSourceProdutos" DataTextField="descricao" DataValueField="id" Visible="false" />
        <asp:ObjectDataSource ID="ObjectDataSourceProdutos" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Produto"></asp:ObjectDataSource>
        <asp:Label ID="Label5" runat="server" text="Unidade" Visible="false" />
        <asp:TextBox ID="TextBoxUnidade" runat="server" Visible="false" />
        <asp:Label ID="Label6" runat="server" text="Quantidade" Visible="false" />
        <asp:TextBox ID="TextBoxQuantidade" runat="server" Visible="false" />
        <asp:Label ID="Label7" runat="server" text="Preço Unitario" Visible="false" />
        <asp:TextBox ID="TextBoxPrecoUnitario" runat="server" Visible="false" />
        <asp:Label ID="Label8" runat="server" text="Valor Total" Visible="false" />
        <asp:TextBox ID="TextBoxValorTotal" runat="server" Visible="false" />
        <asp:Button ID="ButtonIncluir" runat="server" text="Incluir" Visible="false" />
    </div>

    <div>
        <asp:GridView ID="GridViewItens" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceItens" Visible="false" >
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="produto_id" HeaderText="Produto" SortExpression="produto_id" />
                <asp:BoundField DataField="unidade" HeaderText="Unidade" SortExpression="unidade" />
                <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
                <asp:BoundField DataField="precoUnitario" HeaderText="Preço Unitário" SortExpression="precoUnitario" />
                <asp:BoundField DataField="valorTotal" HeaderText="Valor Total" SortExpression="valorTotal" />
                <asp:ButtonField Text="Retirar" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceItens" runat="server" SelectMethod="Listar" TypeName="SiPA.Modelo.ItemCompra">
            <SelectParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>

    <div>

        <asp:Label ID="Label9" runat="server" Text="Desconto" Visible="false"  />
        <asp:TextBox ID="TextBoxDesconto" runat="server"  Visible="false" />
        <asp:Label ID="Label10" runat="server" Text="Valor Total" Visible="false"  />
        <asp:TextBox ID="TextBoxValorTotalCompra" runat="server" enabled="false" Visible="false" />

    </div>

    <div>

        <asp:Button ID="ButtonGravar" runat="server" Text="Gravar" Visible="false"  />
        <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" Visible="false"  />

    </div>
</asp:Content>
