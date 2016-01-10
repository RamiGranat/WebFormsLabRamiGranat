<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Inlamningsuppgift2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="true"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Add to database" OnClick="Button1_Click" />
        <asp:TextBox ID="AddToDatabase" runat="server" Text="Write the name of your product here"></asp:TextBox>
        <asp:Label ID="ErrorLabel" runat="server" Text="" Visible="true"></asp:Label>
    </div>
    </form>
</body>
</html>
