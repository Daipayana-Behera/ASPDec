<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A.aspx.cs" Inherits="UserControlSample.A" %>

<%@ Register Src="~/UserControl.ascx" TagPrefix="uc1" TagName="UserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UserControl runat="server" id="UserControl" /><br />
            <asp:Button ID="btnSub" runat="server" Text="Submit" OnClick="btnSub_Click"/>
        </div>
    </form>
</body>
</html>
