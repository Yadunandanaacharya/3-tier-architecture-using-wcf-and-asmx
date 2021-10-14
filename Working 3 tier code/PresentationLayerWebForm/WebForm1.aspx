<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PresentationLayerWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #FF00FF; color: #000066; font-weight: bold; font-size: xx-large;" >

        <asp:Label ID="Label3" runat="server" Text="User Registration Form"></asp:Label></div>
        
         <br />
        <br />
        
         <br />
        UserId
        <asp:TextBox ID="txtuid" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        <br />
        <br />
        <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" OnClientClick="return confirm('Are you sure ToolTip delete?');" Text="Delete" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
