<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3JobConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            &nbsp;</p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 180px; position: absolute" Text="Yes" />
        </p>
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 39px; top: 84px; position: absolute" Text="Are you sure?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 97px; top: 184px; position: absolute" Text="No" />
    </form>
</body>
</html>
