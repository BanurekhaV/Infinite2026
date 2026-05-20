<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exception_Prj.WebForm1" ErrorPage="~/Myerrpage.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID ="Grid1" runat="server">             

            </asp:GridView>
              <br/><br/>
            <asp:Label ID="lblstatus" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
