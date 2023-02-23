<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A.aspx.cs" Inherits="ValidatorControls.A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqTxtName" runat="server" ControlToValidate="txtname" ErrorMessage="Name textbox can't be empty" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>            
            <asp:RegularExpressionValidator ID="rgTxtName" runat="server" ControlToValidate="txtname" ErrorMessage="Pattern is not matching" ForeColor="Red" ValidationExpression="[A-Z][a-z]+" Text="*" Display="Dynamic"></asp:RegularExpressionValidator>
            <br />

            Age:<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="rngTxtAge" runat="server" ControlToValidate="txtAge" ErrorMessage="Age should be between 18 to 50" ForeColor="Red" MaximumValue="50" MinimumValue="18" Type="Integer" Text="*"></asp:RangeValidator><br />


            New Password: <asp:TextBox ID="txtNewPswd" runat="server"></asp:TextBox><br />
            Confirm Password: <asp:TextBox ID="txtConfPswd" runat="server"></asp:TextBox>
            
            <asp:CompareValidator ID="cmpPswd" runat="server" ControlToCompare="txtConfPswd" ControlToValidate="txtNewPswd" ErrorMessage="Password is different" ForeColor="Red" Text="*"></asp:CompareValidator>
            <br />

            <asp:Button ID="btnSub" Text="Submit" runat="server" /><br />

            <asp:ValidationSummary ID="valid" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
