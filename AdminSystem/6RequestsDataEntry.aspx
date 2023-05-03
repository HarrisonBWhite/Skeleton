<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6RequestsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblRequestID" runat="server" Text="Request ID:"></asp:Label>
        <asp:TextBox ID="txtRequestID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPostcode" runat="server" Text="Postcode: "></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblFlumeCount" runat="server" Text="Flume Count:"></asp:Label>
        <asp:TextBox ID="txtFlumeCount" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
