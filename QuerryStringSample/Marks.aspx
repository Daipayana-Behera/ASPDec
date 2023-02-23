<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Marks.aspx.cs" Inherits="QuerryStringSample.Marks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="txtname" runat="server"></asp:TextBox><br /><br />
            Class:<asp:TextBox ID="txtclass" runat="server"></asp:TextBox><br /><br />
            C# <asp:TextBox ID="txtC" runat="server" TextMode="Number"></asp:TextBox><br /><br />
            HTML<asp:TextBox TextMode="Number" ID="txthtml" runat="server"></asp:TextBox><br /><br />
            SQL<asp:TextBox TextMode="Number" ID="txtsql" runat="server"></asp:TextBox><br /><br />
            Asp<asp:TextBox TextMode="Number" ID="txtasp" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnSub" runat="server" Text="Submit" OnClick="btnSub_Click" />
        </div>
    </form>
</body>
</html>
