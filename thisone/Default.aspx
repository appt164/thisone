<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="thisone._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hello world
        <asp:TextBox runat="server" ID="input1"></asp:TextBox>
        <asp:Button runat="server" ID="doBtn" Text="Calcul" OnClick="doBtn_Click" />
    </div>
    </form>
</body>
</html>
