<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MVPPatternImplemetation.Login" %>
<%@ Register TagName="ucUserDetails" TagPrefix="uc" Src="UserDetails.ascx" %>
<%@ Register TagPrefix="fd" TagName="fdFillDetail" Src="~/FillDetail.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
                        <font color="red"><asp:Label ID="lblMessage" runat="server" ></asp:Label></font>
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
                <tr><th></th></tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                </tr>
              
            </table>

            <!-- ucUserDetails Control-->
            <uc:ucUserDetails ID="ucUserDetails1" runat="server" Visible="False"></uc:ucUserDetails>

               <!-- RegisterUser Control-->
            <fd:fdFillDetail ID="fdFillDetail1" runat="server" Visible="False"></fd:fdFillDetail>
        </div>
    </form>
</body>
</html>
