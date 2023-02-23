<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CookieSample.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName:<asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            Password:<asp:TextBox ID="txtPswd" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSub" runat="server" Text="Submit" OnClick="btnSub_Click" />
        </div>
    </form>
</body>
</html>
