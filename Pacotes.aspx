<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pacotes.aspx.cs" Inherits="Pacotes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pacotes</title>
    <style type="text/css">
        .clearfix
        {
            text-align: center;
        }
        </style>
<!--Start of Tawk.to Script-->
<script type="text/javascript">
    var Tawk_API = Tawk_API || {}, Tawk_LoadStart = new Date();
    (function () {
        var s1 = document.createElement("script"), s0 = document.getElementsByTagName("script")[0];
        s1.async = true;
        s1.src = 'https://embed.tawk.to/58c99e925b8fe5150ef37e95/default';
        s1.charset = 'UTF-8';
        s1.setAttribute('crossorigin', '*');
        s0.parentNode.insertBefore(s1, s0);
    })();
</script>
<!--End of Tawk.to Script-->
<link rel="shortcut icon" href="http://www.tbviagens.com.br/img/favoicon.ico" />
<!-- Facebook Pixel Code -->
<script>
    !function (f, b, e, v, n, t, s) {
        if (f.fbq) return; n = f.fbq = function () {
            n.callMethod ?
  n.callMethod.apply(n, arguments) : n.queue.push(arguments)
        };
        if (!f._fbq) f._fbq = n; n.push = n; n.loaded = !0; n.version = '2.0';
        n.queue = []; t = b.createElement(e); t.async = !0;
        t.src = v; s = b.getElementsByTagName(e)[0];
        s.parentNode.insertBefore(t, s)
    } (window, document, 'script',
  'https://connect.facebook.net/en_US/fbevents.js');
    fbq('init', '166866353880804');
    fbq('track', 'PageView');
</script>
<noscript><img height="1" width="1" style="display:none"
  src="https://www.facebook.com/tr?id=166866353880804&ev=PageView&noscript=1"
/></noscript>
<!-- End Facebook Pixel Code -->
</head>
<body>
<!DOCTYPE HTML>
<html>
<head>

<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Viagens, Nacional, Internacional, Corporativo
Locação de Veículos, Hotéis, Passagens, Aereo,  Transfer" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
<!-- Custom Theme files -->
<link href="css/style.css" rel='stylesheet' type='text/css' />	
<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />
<script src="js/jquery.min.js"> </script>
<!--/script-->
<script type="text/javascript" src="js/move-top.js"></script>
<script type="text/javascript" src="js/easing.js"></script>
<script type="text/javascript">
    jQuery(document).ready(function ($) {
        $(".scroll").click(function (event) {
            event.preventDefault();
            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 900);
        });
    });
</script>
	<script src="js/jquery.chocolat.js"></script>
	<link rel="stylesheet" href="css/chocolat.css" type="text/css"/>
  <!-- Javascript calls -->
		<script type="text/javascript">
		    $(function () {
		        $('#portfolio a').Chocolat({ overlayColor: '#000', leftImg: 'imagens/leftw.gif', rightImg: 'imagens/rightw.gif', closeImg: 'imagens/closew.gif' });
		    });
		</script>


</head>
<body>
	<form id="form1" runat="server">
	<!--start-home-->
	<div id="home" class="header">
		<div class="header-top">
			<div class="container">
				<div class="logo">
					<a href="Default.aspx"><img src="imagens/Logo.png" class="img-responsive"/></h1></a>
				</div>
				<span class="menu"></span>
				<div class="top-menu">
				<ul class="cl-effect-16">
						<li><a class="active" href="Default.aspx" data-hover="Principal">Principal</a></li> 
						<li><a href="SobreNos.aspx" data-hover="Sobre Nós">Sobre Nós</a></li>
						<li><a href="Corporativo.aspx" data-hover="CORPORATIVO">CORPORATIVO</a></li>
						<li><a href="contato.aspx" data-hover="Contato">Contato</a></li>
                        <li><a href="pacotes.aspx" data-hover="Pacotes">Pacotes</a></li>
                        <li><a href="cotacao.aspx" data-hover="Cotação">Cotação</a></li>
                        <li><a href="CompreOnline.aspx" data-hover="Compre Online">Compre Online</a></li>
                        <li><a href="/blog" data-hover="Blog">Blog</a></li>
					</ul>
				</div>
				<div class="top_right">
					<h6>Primeira visita?</h6>
                    <h6>Ligue para informações</h6>
					<p><a href="tel:1123053530">+(55)11-2305-3530</a></p>
					<ul class="f-icons">
						<li><a href="https://www.facebook.com/tbviagens" class="facebook"> </a></li>
                        <li><a href="https://www.instagram.com/tbviagens/" class="instagram"> </a></li>
                        <li><a href="./admin/default.aspx" class="p"> </a></li>
                        <li><a href="tel:1123053530" class="twitter"> </a></li>
					</ul>
			    </div>

			<!-- script-for-menu -->
				<script>
				    $("span.menu").click(function () {
				        $(".top-menu").slideToggle("slow", function () {
				            // Animation complete.
				        });
				    });
			</script>
						<div class="clearfix"></div>
	<!--End-top-nav-script-->
			</div>
		</div>
	<div class="banner">
	     	<div class="container">
					<div  class="callbacks_container">
					<ul class="rslides" id="slider4">
					<li>
								<div class="banner-info">
									<h3>Faça suas malas</h3>
									<h4>O restante nós cuidamos para você...</h4>
								</div>
							</li>
							<li>
								<div class="banner-info">
								   <h3>Escolha o destino</h3>
									<h4>E curta sua viagem...</h4>
								</div>
							</li>
							<li>
								<div class="banner-info">
								  <h3>Aproveite suas férias</h3>
									<h4>Qualquer problema estaremos prontos para ajudá-lo...</h4>
								</div>								
							</li>
						</ul>
					</div>
					<!--banner-->
	  			<script src="js/responsiveslides.min.js"></script>
			 <script>
			     // You can also use "$(window).load(function() {"
			     $(function () {
			         // Slideshow 4
			         $("#slider4").responsiveSlides({
			             auto: true,
			             pager: true,
			             nav: false,
			             speed: 500,
			             namespace: "callbacks",
			             before: function () {
			                 $('.events').append("<li>before event fired.</li>");
			             },
			             after: function () {
			                 $('.events').append("<li>after event fired.</li>");
			             }
			         });

			     });
			  </script>
			</div>
		 </div>
</div>

    <div class="container">
	    <h3 class="tittle few">Veja algumas das suas possibilidades</h3>
		<div class="about-top">
          Conheça o mundo inteiro! Nós montamos um pacote personalizado 
            para sua viagem, acesse a nossa página de <a href="cotacao.aspx">cotação</a>, preencha o formulário e nós criaremos o pacote conforme sua necessidade, para qualquer destino do mundo.<br />
           
    	    </div>
            <br />

             <% ShowPacote.ShowImgPacote("P"); %>
        </div>
     


<!--contact--><div class="contact" id="contact">
			<div class="container">
			 <h3 class="tittle">E-mail Marketing</h3>

				<div class="newslatter">
							<div class="clearfix"></div>
							<div class="support">
                            
                            <asp:TextBox ID="txtNome" runat="server"  MaxLength="50" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Digite seu nome';}">Digite seu nome</asp:TextBox>
                            &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Digite seu e-mail';}">Digite seu e-mail</asp:TextBox>
                             <IMG height="30" alt="" src="Captcha.aspx" >&nbsp;&nbsp;&nbsp;              
                            <asp:TextBox ID="txtCaptcha" runat="server" MaxLength="50" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Informe o numero da imagem';}">Informe o numero da imagem</asp:TextBox>
                            &nbsp; <asp:Button ID="btnGravar" runat="server" onclick="btnGravar_Click" Text="Gravar" class="botton" Height="49px" />
                            &nbsp;
                            <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>


							
							</div>

				   </div>
	        </div>
	    </div>
	<!--map-->
    <div class="map">
	    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3449.549192386088!2d-46.6496198933499!3d-23.651983272845598!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5ac14762740f%3A0x3d7f5c3a4d09dd8c!2sTBViagens!5e0!3m2!1spt-BR!2sbr!4v1456325213604" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
		<span> </span>

	</div>
        	<!--/frase-->
		<div class="frase">
		    <p> <% ShowImagens.MostraMensagem();%></p>
		</div>

	<!--/footer-->
		<div class="copy">
		    <p>TBViagens | Av. Eng. George Corbisier, 1692 – Sala 01 - Jabaquara – São Paulo/SP CEP: 04345-001 | Telefone: (011) 2305-3530 | E-mail: tbviagens@tbviagens.com.br <br> TB Agência de Viagens e Turismo LTDA | Tbviagens LLC | CNPJ: 17.325.345/0001-18 | CADASTUR: 26.057043.10.0001-6 </p>
		</div>
		<!--//footer-->
			<!--start-smoth-scrolling-->
						<script type="text/javascript">
						    $(document).ready(function () {
						        /*
						        var defaults = {
						        containerID: 'toTop', // fading element id
						        containerHoverID: 'toTopHover', // fading element hover id
						        scrollSpeed: 1200,
						        easingType: 'linear' 
						        };
						        */

						        $().UItoTop({ easingType: 'easeOutQuart' });

						    });
								</script>
		<a href="#home" id="toTop" class="scroll" style="display: block;"> <span id="toTopHover" style="opacity: 1;"> </span></a>


    </form>


</body>
</html>