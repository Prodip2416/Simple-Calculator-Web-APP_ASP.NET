<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebAPP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Calculator" Height="209px" Width="423px">
            <asp:Label ID="Label1" runat="server" Text="First Number :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtFirstNumber" runat="server" Height="19px" Width="149px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Second Number :"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSecondNumber" runat="server" Width="151px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Result :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtResult" runat="server" Width="151px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Height="23px" OnClick="btnAdd_Click" Text="Add" Width="66px" />
            &nbsp;<asp:Button ID="btnSubtract" runat="server" Height="23px" OnClick="btnSubtract_Click" Text="Subtract" Width="66px" />
            &nbsp;<asp:Button ID="btnMultiple" runat="server" Height="23px" OnClick="btnMultiple_Click" Text="Multiple" Width="66px" />
            &nbsp;<asp:Button ID="btnDivided" runat="server" Height="23px" OnClick="btnDivided_Click" Text="Divided" Width="66px" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
