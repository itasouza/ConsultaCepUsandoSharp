<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsultaCep.aspx.cs" Inherits="WebConsultaCep.frmConsultaCep" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Consulta de Cep :<br />
        <br />
        Cep:<br />
        <asp:TextBox ID="txtCep" runat="server" Width="147px"></asp:TextBox>
        <br />
        Bairro:<br />
        <asp:TextBox ID="txtBairro" runat="server" Width="231px"></asp:TextBox>
        <br />
        Cidade:<br />
        <asp:TextBox ID="txtCidade" runat="server" Width="231px"></asp:TextBox>
        <br />
        Logradouro:<br />
        <asp:TextBox ID="txtLogradouro" runat="server" Width="435px"></asp:TextBox>
        <br />
        Estado:<br />
        <asp:TextBox ID="txtEstado" runat="server" Width="65px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnConsultar" runat="server" onclick="btnConsultar_Click" 
            Text="Consultar" Width="111px" />
    
    </div>
    </form>
</body>
</html>
