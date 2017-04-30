<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbBankB1000" placeholder="ใส่จำนวนแบงค์ : 1000" runat="server"></asp:TextBox>
            <br />



            <asp:Label ID="lbBankB100" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" OnClick="Submit_Click" Text="Submit" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
