<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Basiccontrols.aspx.cs" Inherits="BasicASPX.SamplePages.Basiccontrols" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 147px">
            <table>
                <tr>
                    <td align="right">
                        <asp:DropDownList ID="CollectionList" runat="server" DataTextField="ViewCollection"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-top: 2px" Text="Choice (RadioButtonList):"
                            Font-Size="Medium" ForeColor="#33cc33" Font-Bold="true">

                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:CheckBox ID="CheckBoxChoice" runat="server">
                        </asp:CheckBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
