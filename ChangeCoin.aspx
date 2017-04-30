<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeCoin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="lbMessage" text="คิดว่าตัวเว็บเวลากด button จะทำการโหลดหน้าใหม่ทุกครั้งเลยทำให้ค่าใน Class bank หายไป วิธีแก้ต้องใช้ XML" runat="server"></asp:Label>
        <br />

        <div>
            <asp:TextBox ID="tbBankB1000" placeholder="ใส่จำนวนแบงค์ : 1000" runat="server"></asp:TextBox>
            <br />

            <asp:TextBox ID="tbBankB500" placeholder="ใส่จำนวนแบงค์ : 500" runat="server"></asp:TextBox>
            <br />

            <asp:TextBox ID="tbBankB100" placeholder="ใส่จำนวนแบงค์ : 100" runat="server"></asp:TextBox>
            <br />

            <asp:TextBox ID="tbBankB50" placeholder="ใส่จำนวนแบงค์ : 50" runat="server"></asp:TextBox>
            <br />

            <asp:TextBox ID="tbCoin10" placeholder="ใส่จำนวนเหรียญ : 10" runat="server"></asp:TextBox>
            <br />

            <asp:TextBox ID="tbCoin5" placeholder="ใส่จำนวนเหรียญ : 5" runat="server"></asp:TextBox>
            <br />

            <asp:TextBox ID="tbCoin1" placeholder="ใส่จำนวนเหรียญ : 1" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="AddBank" OnClick="AddBank_Click" Text="Submit" runat="server" />
            <br />

            <asp:Label ID="lbBankB1000" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbBankB500" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbBankB100" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbBankB50" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbCoin10" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbCoin5" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbCoin1" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbError1" runat="server"></asp:Label>
            <br />
        </div>


        <!-- แลกเหรียญ -->
        <div>

            <asp:TextBox ID="tbMoney" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" OnClick="Submit_Click" Text="Submit" runat="server" />
            <br />

            <asp:Label ID="lbB1000" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbB500" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbB100" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbB50" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbC10" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbC5" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbC1" runat="server"></asp:Label>
            <br />

            <asp:Label ID="lbError" runat="server"></asp:Label>
            <br />
        </div>
    </form>





</body>
</html>
