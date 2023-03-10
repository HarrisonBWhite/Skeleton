<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3JobDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblJobID" runat="server" style="z-index: 1; left: 10px; top: 61px; position: absolute" Text="Job Id:" width="170px"></asp:Label>
        <asp:TextBox ID="txtJobID" runat="server" style="z-index: 1; left: 208px; top: 63px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 11px; top: 115px; position: absolute" Text="Last Name:" width="170px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 207px; top: 117px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblHouseName" runat="server" style="z-index: 1; left: 14px; top: 180px; position: absolute; bottom: 902px" Text="House Name:"></asp:Label>
        <asp:TextBox ID="txtHouseName" runat="server" style="z-index: 1; left: 208px; top: 179px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblComments" runat="server" style="z-index: 1; left: 13px; top: 238px; position: absolute" Text="Comments:" width="170px"></asp:Label>
        <asp:TextBox ID="txtComments" runat="server" style="z-index: 1; left: 209px; top: 240px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 16px; top: 304px; position: absolute" Text="Date:" width="170px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 208px; top: 306px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblJobTake" runat="server" style="z-index: 1; left: 15px; top: 371px; position: absolute" Text="Take: " width="170px"></asp:Label>
        <asp:TextBox ID="txtJobTake" runat="server" style="z-index: 1; left: 208px; top: 368px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblVisits" runat="server" style="z-index: 1; left: 15px; top: 429px; position: absolute" Text="Total Visits:" width="170px"></asp:Label>
        <asp:TextBox ID="txtTotalVisits" runat="server" style="z-index: 1; left: 207px; top: 429px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 496px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 561px; position: absolute" Text="OK" />
        <asp:Button ID="btnCnacel" runat="server" style="z-index: 1; left: 84px; top: 562px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
