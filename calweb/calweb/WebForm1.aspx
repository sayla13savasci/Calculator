<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calweb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 333px; width: 543px; margin-left: 40px">
    
        <asp:TextBox ID="TextBox1" runat="server" Height="38px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 36px; margin-top: 13px" Width="193px"></asp:TextBox>
        <asp:Button ID="Button30" runat="server" Height="40px" OnClick="Button30_Click" style="margin-left: 20px" Text="Normal" Width="52px" />
        <asp:Button ID="Button23" runat="server" Height="40px" OnClick="Button23_Click" style="margin-left: 17px" Text="Scientific" Width="58px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="7" Width="57px" />
        <asp:Button ID="Button2" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="8" Width="57px" />
        <asp:Button ID="Button3" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="9" Width="57px" />
        <asp:Button ID="Button4" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="/" Width="57px" />
&nbsp;<asp:Button ID="Button5" runat="server" Height="40px" OnClick="Button5_Click" style="margin-left: 17px" Text="CE" Width="57px" />
        <asp:Button ID="Button6" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="sin" Width="57px" />
        <asp:Button ID="Button25" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="cos" Width="57px" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="4" Width="57px" />
        <asp:Button ID="Button8" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="5" Width="57px" />
        <asp:Button ID="Button10" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="6" Width="57px" />
        <asp:Button ID="Button11" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="*" Width="57px" />
        <asp:Button ID="Button12" runat="server" Height="40px" OnClick="Button12_Click" style="margin-left: 17px" Text="C" Width="57px" />
        <asp:Button ID="Button26" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="tan" Width="57px" />
        <asp:Button ID="Button29" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="ln" Width="57px" />
        <br />
        <br />
        <asp:Button ID="Button13" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="1" Width="57px" />
        <asp:Button ID="Button14" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="2" Width="57px" />
        <asp:Button ID="Button15" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="3" Width="57px" />
        <asp:Button ID="Button16" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="-" Width="57px" />
        <asp:Button ID="Button17" runat="server" Height="40px" OnClick="Button17_Click" style="margin-left: 17px" Text="=" Width="57px" />
        <asp:Button ID="Button18" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="log" Width="57px" />
        <asp:Button ID="Button27" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="%" Width="57px" />
        <br />
        <br />
        <asp:Button ID="Button19" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="0" Width="57px" />
        <asp:Button ID="Button20" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="√" Width="57px" />
        <asp:Button ID="Button21" runat="server" Height="40px" OnClick="button_Click" style="margin-left: 17px" Text="." Width="57px" />
        <asp:Button ID="Button22" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="+" Width="57px" />
        <asp:Button ID="Button24" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="^" Width="57px" />
        <asp:Button ID="Button28" runat="server" Height="40px" OnClick="Operator_Click" style="margin-left: 17px" Text="1/x" Width="57px" />
    
    </div>
    </form>
</body>
</html>
