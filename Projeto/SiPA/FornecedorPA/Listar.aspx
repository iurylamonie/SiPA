<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="SiPA.FornecedorPA.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:button runat="server" text="Incluir" id="ButtonIncluir" OnClick="ButtonIncluir_Click" />
        <asp:button runat="server" text="Atualizar Dados" id="ButtonAtualizar"  />        
    </div>

    <div>
        <asp:GridView ID="GridViewFornecedores" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceFornecedores" OnRowCommand="GridViewFornecedores_RowCommand">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                <asp:BoundField DataField="telefone" HeaderText="Telefones" SortExpression="telefone" />
                <asp:ButtonField CommandName="Selecionar" Text="Selecionar" />
                <asp:ButtonField CommandName="Alterar" Text="Alterar" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            </Columns>
        </asp:GridView>    
        <asp:ObjectDataSource ID="ObjectDataSourceFornecedores" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Fornecedor"></asp:ObjectDataSource>
    </div>

    <div>
        <asp:Label ID="Label1" runat="server" Text="Endereço: "></asp:Label>
        <asp:Label ID="LabelEndereco" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Cidade: "></asp:Label>
        <asp:Label ID="LabelCidade" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="CPF/CNPJ: "></asp:Label>
        <asp:Label ID="LabelCPFCNPJ" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="E-mail: "></asp:Label>
        <asp:Label ID="LabelEmail" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
