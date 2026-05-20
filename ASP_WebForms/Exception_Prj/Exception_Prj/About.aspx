<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Exception_Prj.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>
        <asp:Label ID="lblmsg" runat="server" ></asp:Label>
        <asp:TextBox ID="txtmsg" runat="server"></asp:TextBox>
        <asp:Button ID="btnclick" runat="server" Text="click" OnClick="btnclick_Click" />
    </main>
</asp:Content>
