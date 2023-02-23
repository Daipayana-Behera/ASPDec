<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="QuerryStringSample.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
            Password:<asp:TextBox ID="txtPswd" runat="server" TextMode="Password"></asp:TextBox><br /><br />
            <asp:Button ID="txtbtn" runat="server" Text="Submit" OnClick="txtbtn_Click" />
        </div>
    </form>
</body>
</html>
