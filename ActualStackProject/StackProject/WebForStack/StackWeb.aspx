<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StackWeb.aspx.cs" Inherits="WebForStack.StackWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <table>                
                <tr>
                    <td>Enter the value to be pushed</td>
                    <td>                     
                        <asp:TextBox ID="txtPush" runat="server"></asp:TextBox>
                    </td>    
                    <td></td>                
                </tr>
                <tr>    
                    <td colspan="3" align="center">
                        <asp:Button ID="btnPush" runat="server" Text="Push" OnClick="btnPush_Click" />                    
                        <asp:Button ID="btnPop" runat="server" Text="Pop" OnClick="btnPop_Click" />                    
                        <asp:Button ID="btnViewAll" runat="server" Text="ViewAll" OnClick="btnViewAll_Click" />
                    </td>
                <tr>
                    <td colspan="3" align="center">
                        <asp:Label ID="lblDisplay" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

            </table>
        </center>
    
    </div>
    </form>
</body>
</html>
