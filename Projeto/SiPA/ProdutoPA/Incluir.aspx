<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Incluir.aspx.cs" Inherits="SiPA.ProdutoPA.Incluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="TextBoxDescricao" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button CssClass="btn btn-default" ID="ButtonCancelar" runat="server" Text="Cancelar" OnClick="ButtonCancelar_Click" />
        <asp:Button CssClass="btn btn-success" ID="ButtonIncluir" runat="server" Text="Incluir" OnClick="ButtonIncluir_Click" />
    </div>
</asp:Content>
