<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FillDetail.ascx.cs" Inherits="MVPPatternImplemetation.FillDetail" %>
<h4>
    <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
</h4>
<table>
    <tr><th>User ID</th><td><asp:TextBox ID="txtID" runat="server"></asp:TextBox> </td></tr>
    <tr><th>Name</th><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td></tr>
    <tr><th>Contact No.</th><td><asp:TextBox ID="txtContact" runat="server"></asp:TextBox></td></tr>
    <tr><th>Address</th><td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td></tr>
    <tr><td colspan="2"><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td></tr>
</table>