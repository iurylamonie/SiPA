<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="SiPA.ProdutoPA.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:button runat="server" text="Incluir" id="ButtonIncluir" OnClick="ButtonIncluir_Click"/>
        <asp:button runat="server" text="Atualizar Dados" id="ButtonAtualizar" OnClick="ButtonAtualizar_Click" />        
    </div>

    <div>

        <asp:GridView ID="GridViewProduto" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceProdutos" OnRowCommand="GridViewProduto_RowCommand">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                <asp:ButtonField CommandName="Alterar" Text="Alterar" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceProdutos" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Produto"></asp:ObjectDataSource>

    </div>
</asp:Content>
