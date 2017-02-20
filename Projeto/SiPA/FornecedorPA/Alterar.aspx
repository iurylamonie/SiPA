<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="SiPA.FornecedorPA.Alterar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Código" ></asp:Label>
        <asp:TextBox ID="TextBoxId" enabled="false" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Telefone(s)"></asp:Label>
        <asp:TextBox ID="TextBoxTelefone" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Cidade"></asp:Label>
        <asp:TextBox ID="TextBoxCidade" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="TextBoxEstado" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="Endereço"></asp:Label>
        <asp:TextBox ID="TextBoxEndereço" runat="server"></asp:TextBox><br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>CPF</asp:ListItem>
            <asp:ListItem>CNPJ</asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="TextBoxCPFCNPJ" runat="server"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="E-mail"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" OnClick="ButtonCancelar_Click"/>
        <asp:Button ID="ButtonAlterar" runat="server" Text="Alterar" OnClick="ButtonAlterar_Click"  />
    </div>
</asp:Content>
