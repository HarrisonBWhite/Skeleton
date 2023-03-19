<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4FinanceDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            <asp:Label ID="lblFinanceID" runat="server" Text="Finance ID:"></asp:Label>
            <asp:TextBox ID="txtFinanceID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDate" runat="server" Text="Date:"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblJobTake" runat="server" Text="Take: "></asp:Label>
        <asp:TextBox ID="txtJobTake" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
