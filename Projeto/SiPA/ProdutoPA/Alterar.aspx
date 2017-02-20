<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="SiPA.ProdutoPA.Alterar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="LabelId" runat="server" Text="Código"></asp:Label>
        <asp:TextBox ID="TextBoxId" runat="server" Enabled="false" /> <br />
        <asp:Label ID="LabelDescricao" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="TextBoxDescricao" runat="server"  />
    </div>

    <div>
        <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" OnClick="ButtonCancelar_Click" />
        <asp:Button ID="ButtonAlterar" runat="server" Text="Alterar" OnClick="ButtonAlterar_Click" />
    </div>
</asp:Content>
