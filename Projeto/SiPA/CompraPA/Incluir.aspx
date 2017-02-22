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

    
</asp:Content>
