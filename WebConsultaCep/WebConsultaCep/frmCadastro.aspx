<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadastro.aspx.cs" Inherits="WebConsultaCep.frmCadastro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileFotoProduto" runat="server" />
        <br />
    </div>
    <asp:ListBox ID="listbox" runat="server" Width="1007px"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnGravar" runat="server" onclick="btnGravar_Click" 
        Text="Gravar" Width="110px" />
    </form>
</body>
</html>
