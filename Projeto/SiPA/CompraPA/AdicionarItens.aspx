<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="AdicionarItens.aspx.cs" Inherits="SiPA.CompraPA.AdicionarItens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label ID="LabelCompraId" runat="server" />
    </div>
<div>
        <asp:Label ID="Label3" runat="server" text="ITENS DA COMPRA"  /><br />
        <asp:Label ID="Label4" runat="server" text="Produto" Visible="false" />
        <asp:DropDownList ID="DropDownListProdutos" runat="server" DataSourceID="ObjectDataSourceProdutos" DataTextField="descricao" DataValueField="id" Visible="true" />
        <asp:ObjectDataSource ID="ObjectDataSourceProdutos" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Produto"></asp:ObjectDataSource>
        <asp:Label ID="Label5" runat="server" text="Unidade" Visible="true" />
        <asp:TextBox ID="TextBoxUnidade" runat="server" Visible="true" />
        <asp:Label ID="Label6" runat="server" text="Quantidade" Visible="true" />
        <asp:TextBox ID="TextBoxQuantidade" runat="server" Visible="true" />
        <asp:Label ID="Label7" runat="server" text="Preço Unitario" Visible="true" />
        <asp:TextBox ID="TextBoxPrecoUnitario" runat="server" Visible="true" />

        <asp:Button ID="ButtonIncluir" runat="server" text="Incluir" Visible="true" OnClick="ButtonIncluir_Click" />
    </div>

    <div>
        <asp:GridView ID="GridViewItens" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceItens" OnRowCommand="GridViewItens_RowCommand"  >
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                <asp:BoundField DataField="produto_id" HeaderText="Produto" SortExpression="produto_id" />
                <asp:BoundField DataField="unidade" HeaderText="Unidade" SortExpression="unidade" />
                <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
                <asp:BoundField DataField="precoUnitario" HeaderText="Preço Unitário" SortExpression="precoUnitario" />
                <asp:BoundField DataField="valorTotal" HeaderText="Valor Total" SortExpression="valorTotal" />
                <asp:ButtonField CommandName="Remover" Text="Remover" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceItens" runat="server" SelectMethod="Listar" TypeName="SiPA.Modelo.ItemCompra">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="com-id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>

    <div>

        <asp:Label ID="Label9" runat="server" Text="Desconto" Visible="true"  />
        <asp:TextBox ID="TextBoxDesconto" runat="server"  Visible="true" />
        <asp:Label ID="Label10" runat="server" Text="Valor Total" Visible="true"  />
        <asp:TextBox ID="TextBoxValorTotal" runat="server" enabled="false" Visible="true" />

    </div>

    <div>

        <asp:Button ID="ButtonGravar" runat="server" Text="Gravar" Visible="true" OnClick="ButtonGravar_Click"  />
        <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" Visible="true" OnClick="ButtonCancelar_Click"  />

    </div>
</asp:Content>
