<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" width="97px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="97px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="97px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblHouseName" runat="server" Text="House Name:" width="97px"></asp:Label>
            <asp:TextBox ID="txtHouseName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStreet" runat="server" Text="Street:" width="97px"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblTown" runat="server" Text="Town:" width="97px"></asp:Label>
            <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCounty" runat="server" Text="County:" width="97px"></asp:Label>
        <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPostcode" runat="server" Text="Postcode:" width="97px"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number:" width="97px"></asp:Label>
        <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email:" width="97px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalChimneys" runat="server" Text="Total Chimneys:"></asp:Label>
        <asp:TextBox ID="txtTotalChimneys" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblComments" runat="server" Text="Comments:" width="97px"></asp:Label>
        <asp:TextBox ID="txtComments" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalVisits" runat="server" Text="Total Visits:" width="97px"></asp:Label>
        <asp:TextBox ID="txtTotalVisits" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
