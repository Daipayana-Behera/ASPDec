<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A.aspx.cs" Inherits="SessionSample2.A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number:<asp:TextBox ID="txtNum" TextMode="Number" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSub" Text="Submit" runat="server" OnClick="btnSub_Click" />
        </div>
    </form>
</body>
</html>
