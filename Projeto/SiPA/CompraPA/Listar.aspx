<%@ Page Title="" Language="C#" MasterPageFile="~/SiPAMaster.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="SiPA.CompraPA.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <asp:button runat="server" text="Incluir" id="ButtonIncluir" OnClick="ButtonIncluir_Click"/>
        <asp:button runat="server" text="Atualizar Dados" id="ButtonAtualizar"  />        
    </div>
    
    <div>
        <asp:Label ID="Label1" runat="server" Text="Filtrar por:" /> <br />
        <asp:Label ID="Label2" runat="server" Text="Fornecedor" /> 
        <asp:RadioButtonList ID="RadioButtonListEscolha" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonListEscolha_SelectedIndexChanged">
            <asp:ListItem>Todos</asp:ListItem>
            <asp:ListItem Value="Especifico">Específico</asp:ListItem>
        </asp:RadioButtonList>
        <asp:DropDownList ID="DropDownListFornecedores" runat="server" DataSourceID="ObjectDataSourceFornecedores" DataTextField="nome" DataValueField="id" Enabled="false" >
            <asp:ListItem>Todos</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="Periodo" /> 
        <asp:Calendar ID="CalendarPeridodo" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <asp:ObjectDataSource ID="ObjectDataSourceFornecedores" runat="server" SelectMethod="Lista" TypeName="SiPA.Modelo.Fornecedor"></asp:ObjectDataSource>
        <asp:Button ID="ButtonPesquisar" runat="server" Text="Pesquisar" />    
    </div>

    <div>
        <asp:GridView ID="GridViewCompras" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceCompras" OnRowCommand="GridViewCompras_RowCommand">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                <asp:BoundField DataField="dataCompra" HeaderText="Data" SortExpression="dataCompra" />
                <asp:BoundField DataField="Fornecedor.nome" HeaderText="Fornecedor" SortExpression="Fornecedor.nome" />
                <asp:BoundField DataField="desconto" HeaderText="Desconto" SortExpression="desconto" />
                <asp:BoundField DataField="valorTotal" HeaderText="Valor Total" SortExpression="valorTotal" />
                <asp:ButtonField CommandName="Selecionar" Text="Selecionar" />
                <asp:ButtonField CommandName="Alterar" Text="Alterar" />
                <asp:ButtonField CommandName="Excluir" Text="Excluir" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceCompras" runat="server" SelectMethod="Listar" TypeName="SiPA.Modelo.Compra"></asp:ObjectDataSource>
    </div>

    <div>
        <asp:Label ID="Label4" runat="server" text="ITENS DA COMPRA" />
        <asp:GridView ID="GridViewItens" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceItens">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                <asp:BoundField DataField="produto_id" HeaderText="Produto" SortExpression="produto_id" />
                <asp:BoundField DataField="unidade" HeaderText="Unidade" SortExpression="unidade" />
                <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
                <asp:BoundField DataField="precoUnitario" HeaderText="Preço Unitário" SortExpression="precoUnitario" />
                <asp:BoundField DataField="valorTotal" HeaderText="Valor Total" SortExpression="valorTotal" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceItens" runat="server" SelectMethod="Listar" TypeName="SiPA.Modelo.ItemCompra">
            <SelectParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
