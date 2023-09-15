<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Quadrado</title>
    <style>
        body {
            font-family: Calibri;
        }
    </style>
</head>
<body>
    <h2>Quadrado de um valor - um Web app simples</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Digite um valor:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="55px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Quadrado" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="O quadrado é: "></asp:Label>
        </div>
    </form>
</body>
</html>
