<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsLabRamiGranat.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Input1" runat="server"></asp:TextBox>
            <asp:Button ID="SekButton" runat="server" OnClick="SekButton_Click" Text="Sek"/>
            <asp:Button ID="EuroButton" runat="server" OnClick="EuroButton_Click" Text="Euro"/>
            <asp:Button ID="PoundButton" runat="server" OnClick="PoundButton_Click" Text="Brit. Pound"/>
            <asp:Button ID="USDButton" runat="server" OnClick="USDButton_Click" Text="USD"/>
            <asp:Button ID="CADButton" runat="server" OnClick="CADButton_Click" Text="CAD"/><br />
            <asp:Button ID="ConvertButton" runat="server" OnClick="ConvertButton_Click" Text="Convert"/>
            <asp:Label ID="Result" runat="server">The result is shown here</asp:Label>
        </div>
    </form>
</body>
</html>
