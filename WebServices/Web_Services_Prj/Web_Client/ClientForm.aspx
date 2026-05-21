<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="Web_Client.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter User Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            <br /><br />
            Enter a Float Number : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtfnum" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnHello" Text="Hello World" runat="server" OnClick="btnHello_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSayhello" Text="Say Hello" runat="server" OnClick="btnSayhello_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsquare" Text=" Get Numbers Square" runat="server" OnClick="btnsquare_Click" />
            <br /><br />
            <asp:Label ID ="lblstatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
