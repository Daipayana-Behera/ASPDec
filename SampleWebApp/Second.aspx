<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="SampleWebApp.Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            N1:<asp:TextBox TextMode="Number" ID="txtn1" runat="server"></asp:TextBox><br />
            N2:<asp:TextBox TextMode="Number" ID="txtn2" runat="server"></asp:TextBox><br />
            Operation: <asp:RadioButton ID="rddiv" runat="server" Text="Div" GroupName="operation" />
                       <asp:RadioButton ID="rdadd" runat="server" Text="Add" GroupName="operation" />
                       <asp:RadioButton ID="rdsub" runat="server" Text="Sub" GroupName="operation" />
                       <asp:RadioButton ID="rdmulti" runat="server" Text="Multi" GroupName="operation" /><br />
            <asp:Button runat="server" Text="Submit" ID="btnsubmit" />
        </div>
    </form>
</body>
</html>
