<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDetails.ascx.cs" Inherits="MVPPatternImplemetation.UserDetails" %>
 <h3>
                <asp:Label ID="lblUser" runat="server"></asp:Label>
            </h3>
<table runat="server" id="tblView">
    <tr>
        <th>ID</th>
        <td>
            <asp:Label runat="server" ID="lblUserID"></asp:Label>
        </td>
    </tr>
    <tr>
        <th>Name</th>
        <td>
            <asp:Label runat="server" ID="lblUserName"></asp:Label></td>
    </tr>
    <tr>
        <th>Address</th>
        <td>
            <asp:Label runat="server" ID="lblAddress"></asp:Label></td>
    </tr>
    <tr>
        <th>Contact No.</th>
        <td>
            <asp:Label runat="server" ID="lblContact"></asp:Label></td>
    </tr>
   
</table>
<table runat="server" ID="tblEdit" Visible="False">
    <tr><th>User ID</th><td><asp:TextBox ID="txtID" runat="server"></asp:TextBox> </td></tr>
    <tr><th>Name</th><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td></tr>
    <tr><th>Contact No.</th><td><asp:TextBox ID="txtContact" runat="server"></asp:TextBox></td></tr>
    <tr><th>Address</th><td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td></tr>
    <tr><td colspan="2"><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td></tr>
</table>
