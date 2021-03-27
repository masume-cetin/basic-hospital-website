<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personel.aspx.cs" Inherits="HastaneSite.personelform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Properties/staff.jpg); background-size:cover;">
    <form id="form1" runat="server">
        <div>
            <table style="border:1px solid black;margin-left:auto;margin-right:auto;margin-top:300px;">
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="PERSONEL GİRİŞ PORTALI"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="İsminiz:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Tc Kimlik Numaranız:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="BtnLogin" runat="server" Text="Giriş Yap" OnClick="BtnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblErrorMessage" runat="server" Text="Yanlış isim id bilgisi girdiniz" ForeColor="RED"></asp:Label>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
