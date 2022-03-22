<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    enter Empno<asp:TextBox ID="txteno" runat="server" />
        <br />
        <br />
        enter Empname<asp:TextBox ID="txtename" runat="server" />
        <br />
        <br />
        enter salary<asp:TextBox ID="txtesal" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        <br />
        <br />
        <asp:Label ID="LblMsg" runat="server" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
