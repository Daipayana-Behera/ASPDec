<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="SampleWebApp.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" Height="279px">
                <asp:TableRow>
                    <asp:TableCell>Name:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Age:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Gender:</asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButton ID="rdMale" runat="server" Text="Male" GroupName="Gender"/>
                        <asp:RadioButton ID="rdFemale" runat="server" Text="Female" GroupName="Gender"/>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Course:</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlCourse" runat="server">
                            <asp:ListItem>--Select--</asp:ListItem>
                            <asp:ListItem>Python</asp:ListItem>
                            <asp:ListItem>Java</asp:ListItem>
                            <asp:ListItem>C#</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

                 <asp:TableRow>
                
                    <asp:TableCell>City:</asp:TableCell>
                     <asp:TableCell>
                     <asp:DropDownList ID="ddlCity" runat="server">
                            <asp:ListItem>--Select--</asp:ListItem>
                            <asp:ListItem>Bangalore</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Pune</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>Email:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnSub" runat="server" Text="Submit" OnClick="btnSub_Click"></asp:Button>
                    </asp:TableCell>

                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
