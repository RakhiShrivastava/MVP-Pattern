<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MVPPage.aspx.cs" Inherits="MVPPatternImplemetation.MVPPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <form id="form2" runat="server">
        <div>
            <!-- User Login-->
            <table id="tblLogin" runat="server">
                <tr>
                    <th colspan="2">
                        <h2>Login</h2>
                    </th>
                </tr>
                <tr>
                    <th colspan="2">
                        <font color="red"><asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label></font>
                    </th>
                </tr>
                <tr>
                    <th>Login ID</th>
                    <td>
                        <asp:TextBox ID="txtLoginID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Password</th>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            <!-- ucUserDetails Control-->
            <uc:ucControl ID="ucUserDetails1" runat="server" Visible="False"></uc:ucControl>
        </div>
    </form>
    </div>
    </form>
</body>
</html>
