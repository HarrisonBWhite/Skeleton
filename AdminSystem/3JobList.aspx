<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3JobList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstJobList" runat="server" Height="493px" Width="548px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 8px; top: 578px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 98px; top: 579px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 807px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 580px; position: absolute" Text="Delete" />
        <asp:Label ID="lblInstruct" runat="server" style="z-index: 1; left: 13px; top: 679px; position: absolute" Text="Enter a surname:"></asp:Label>
        <asp:TextBox ID="txtAnswer" runat="server" style="z-index: 1; left: 234px; top: 681px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 13px; top: 754px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 126px; top: 755px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
