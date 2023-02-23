<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="B.aspx.cs" Inherits="LoadingData.B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            States: <asp:DropDownList ID="ddlStates" runat="server" OnSelectedIndexChanged="ddlStates_SelectedIndexChanged" AutoPostBack="true">

                    </asp:DropDownList>
            City: <asp:DropDownList ID="ddlCity" runat="server">

                  </asp:DropDownList><br />
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
        </div>
    </form>
</body>
</html>
