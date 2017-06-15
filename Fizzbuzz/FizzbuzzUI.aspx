<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FizzbuzzUI.aspx.cs" Inherits="Fizzbuzz.Fizzbuzz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 0px auto; overflow: auto;">
            <div>
                <table width="50%" align="Center">
                    <tr>
                        <td colspan="2" style="background-color: #0000FF; color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-weight: normal; font-size: x-large; line-height: 30px;" align="center">FizzBuzz
                        </td>
                    </tr>
                    <tr>
                        <td align="Right">Please enter an number:</td>
                        <td width="75%">
                            <asp:TextBox ID="txtNum" Width="75%" runat="server" KeyPress="txtNum_KeyPress"></asp:TextBox>
                            <br />
                            <asp:CompareValidator ID="validNum" runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtNum" ErrorMessage="Value must be a whole number" />
                            <asp:RequiredFieldValidator ID="validTxt" runat="server" ErrorMessage="Please enter a number" ControlToValidate="txtNum"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="btnSubmit" runat="server" Width="100px" Text="Submit" Align="Center" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="lblFizzBuzz" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>

    </form>
</body>
</html>
