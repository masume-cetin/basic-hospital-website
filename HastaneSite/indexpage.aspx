<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexpage.aspx.cs" Inherits="HastaneSite.indexpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nemesis Hastanesi</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <header style="background-image: url(https://image.freepik.com/free-vector/blue-medical-healthcare-background-with-cardiograph_1017-14999.jpg);">
            <a href="index.html" class="header-brand">NEMESIS HASTANESİ</a>
        <nav class="top-menu">
            <ul>
                <li><p>hakkımızda</p></li>
                <li><p>çalışanlarımız</p></li>
                <li><p>iletişim</p></li>
              <li class="login-fix">
                    <p>giriş:</p>
                    <select class="login" name="login" onchange="javascript:handleSelect(this)">
                        <option value="personel"  selected="false">personel</option >
                        <option value="yatılıhasta" selected="false">yatılı hasta</option>
                        <option value="hasta" selected="false">hasta</option>
                    </select>
                    <script type="text/javascript">
                        function handleSelect(elm) {
                            window.location = elm.value + ".aspx";
                        }
                    </script>
                </li>
            </ul>
        </nav>
    </header>
       <div class="slidercontainer">
        <div class="showSlide fade">
            <img src="Properties/images/img1.jpg" />
            <div class="content">misyonumuz</div>
        </div>
        <div class="showSlide fade">
            <img src="Properties/images/img2.jpg" />
            <div class="content">ücretlendirme</div>
        </div>

        <div class="showSlide fade">
            <img src="Properties/images/img3.jpg"/>
            <div class="content">adresimiz</div>
        </div>
        <div class="showSlide fade">
            <img src="Properties/images/img4.jpg" />
            <div class="content">web sitemiz hakkında</div>
        </div>
        <!-- Navigation arrows -->
        <a class="left" onclick="nextSlide(-1)">❮</a>
        <a class="right" onclick="nextSlide(1)">❯</a>
    </div>

    <script type="text/javascript">
        var slide_index = 1;
        displaySlides(slide_index);

        function nextSlide(n) {
            displaySlides(slide_index += n);
        }

        function currentSlide(n) {
            displaySlides(slide_index = n);
        }

        function displaySlides(n) {
            var i;
            var slides = document.getElementsByClassName("showSlide");
            if (n > slides.length) { slide_index = 1 }
            if (n < 1) { slide_index = slides.length }
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }
            slides[slide_index - 1].style.display = "block";
        }
    </script>


    <div class="wrapper">
        <div class="cases-link">
            <p>adres</p>
        </div>
        <div class="cases-link">
            
            <img src="Properties/images/map.jpg" alt="map" usemap="#workmap" />

<map name="workmap">
<area shape="circle" coords="337,300,44" onclick="myFunction()"/>
  
</map>
            <script>
                function myFunction() {
                    alert("You clicked the nemesıs hospıtal");
                }
            </script>
            <h1>Konum</h1>
        </div>
        <div class="cases-link">
            <p>iletişim</p>
        </div>
        <div class="cases-link">
            <p>doktorlar</p>
            <asp:ImageButton CssClass="imgbtn" ID="DocImgBtn" runat="server" Height="212px" ImageUrl="~/Properties/docteam.jpg" OnClick="DocImgBtn_Click" Width="231px" />
        </div>
        <div class="cases-link">
            <p>randevu alma</p>
            <asp:ImageButton CssClass="imgbtn" ID="RandevuImgBtn" runat="server" ImageUrl="~/Properties/randevu.jpg" OnClick="RandevuImgBtn_Click" />
        </div>
        <div class="cases-link">
            <p>randevu sorgulama</p>
            <asp:ImageButton CssClass="imgbtn" ID="SorguRandevuImgBtn" runat="server" ImageUrl="~/Properties/randevusorgu.jpg" OnClick="SorguRandevuImgBtn_Click" />
        </div>
        <div class="cases-link">
            <p>şikayet</p>
        </div>
        <div class="cases-link">
            <p>hakkımızda</p>
        </div>
    </div>

    </form>
</body>
</html>
