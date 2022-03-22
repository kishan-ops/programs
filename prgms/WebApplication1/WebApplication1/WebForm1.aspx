<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnTextcolor" runat="server" ForeColor="Red" OnClick="Button2_Click" Text="textcolor" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnBackcolour" runat="server" BackColor="Blue" ForeColor="Blue" OnClick="btnBackcolour_Click" style="width: 84px" Text="backcolor" />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
