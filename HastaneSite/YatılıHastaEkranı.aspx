<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YatılıHastaEkranı.aspx.cs" Inherits="HastaneSite.YatılıHastaEkranı" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Yatılı Hasta Ekranına Hoşgeldiniz"></asp:Label>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 50%; padding-bottom: 50%; background-image:url(Properties/images/travel.jpg); background-size:contain "><a href="https://sanalgezinti.com/tr/referans-sehirler-muzeler.html">Seyahat</a></td>
                    <td style="width: 50%; padding-bottom: 50%; background-image:url(Properties/images/starrynight.jpg); background-size:contain"><a href="https://stellarium-web.org">yıldızları seyret</a></td>
                   
                </tr>
                <tr>
                    <td style="width: 50%; padding-bottom: 50%; background-image:url(Properties/images/nature.jpg); background-size:contain"><a href="http://www.allolo.ru/?id=13">doğa&ses</a></td>
                    <td style="width: 50%; padding-bottom: 50%; background-image:url(Properties/images/koroyonetme.jpg); background-size:contain"><a href="https://www.incredibox.com/demo/">akapella yönet</a></td>

                </tr>
                <tr>
                    <td style="width: 50%; padding-bottom: 50%; background-image:url(Properties/images/book.jpg); background-size:contain"><a href="https://www.onread.com">kitap</a></td>
                    <td style="width: 50%; padding-bottom: 50%; background-image:url(Properties/images/game.jpg); background-size:contain"><a href="http://www.flashbynight.com">oyunlar</a></td>

                </tr>
            </table>
        </div>
        <div>

        </div>
    </form>
</body>
</html>
