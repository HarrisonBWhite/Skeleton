<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3JobViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customer Page" />
        <p>
            <asp:Button ID="btnJobPage" runat="server" OnClick="btnJobPage_Click" Text="Job Page" />
        </p>
        <asp:Button ID="btnFinancePage" runat="server" OnClick="btnFinancePage_Click" Text="Finance Page" />
    </form>
</body>
</html>
