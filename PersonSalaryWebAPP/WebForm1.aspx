<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PersonSalaryWebAPP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Salary Calculator" Height="313px" Width="557px">
            <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmployeeName" runat="server" Width="214px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Basic Amount"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBasicAmount" runat="server" Width="97px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<br /><br /><asp:Label ID="Label3" runat="server" Text="House Rent"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtHouseRent" runat="server" Width="97px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="% of Basic"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Medical Allowance"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtMedicalAllowance" runat="server" Width="99px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="% of Basic"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnShowMeSalary" runat="server" OnClick="btnShowMeSalary_Click" Text="Show Me Salary" Width="226px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMessage" runat="server"></asp:Label>

        </asp:Panel>
    </div>
    </form>
</body>
</html>
