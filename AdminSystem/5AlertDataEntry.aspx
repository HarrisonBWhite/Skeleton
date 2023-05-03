<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5AlertDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAlertID" runat="server" Text="Alert ID:"></asp:Label>
        <asp:TextBox ID="txtAlertID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDate" runat="server" Text="Date: "></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblReminderInterval" runat="server" Text="Reminder Interval: "></asp:Label>
            <asp:TextBox ID="txtReminderInterval" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
