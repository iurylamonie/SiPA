<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="SiPA.ProdutoPA.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="panel">
    <div class="panel panel-heading">
        <asp:button CssClass="btn btn-success" runat="server" text="Incluir" id="ButtonIncluir" OnClick="ButtonIncluir_Click"/>
        <asp:button CssClass="btn btn-default" runat="server" text="Atualizar Dados" id="ButtonAtualizar" OnClick="ButtonAtualizar_Click" />        
    </div>

    <div class="panel panel-body">

        <asp:GridView ID="GridViewProduto" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceProdutos" OnRowCommand="GridViewProduto_RowCommand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                <asp:BoundField DataField="descricao" HeaderText="Descrição" SortExpression="descricao" />
                <asp:ButtonField ControlStyle-CssClass="btn btn-info" CommandName="Alterar" Text="Alterar" ButtonType="Button" />
                <asp:ButtonField ControlStyle-CssClass="btn btn-danger" CommandName="Excluir" Text="Excluir" ButtonType="Button" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceProdutos" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Produto"></asp:ObjectDataSource>

    </div>
        </div>
</asp:Content>
