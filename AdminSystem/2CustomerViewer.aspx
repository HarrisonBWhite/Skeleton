<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnCustomerPage" runat="server" OnClick="btnCustomerPage_Click" Text="Customer Page" Width="135px"/>
        </p>
        <asp:Button ID="btnAlertsPage" runat="server" OnClick="btnAlertsPage_Click" Text="Alerts Page" Width="135px"/>
        <p>
            <asp:Button ID="btnRequestsPage" runat="server" OnClick="btnRequestsPage_Click" Text="Requests Page" Width="135px" />
        </p>
        <p>
            <asp:Button ID="btnJobPage" runat="server" OnClick="btnJobPage_Click" Text="Job Page" Width="135px"/>
        </p>
        <asp:Button ID="btnFinancePage" runat="server" OnClick="btnFinancePage_Click" Text="Finance Page" Width="135px"/>
    </form>
</body>
</html>
