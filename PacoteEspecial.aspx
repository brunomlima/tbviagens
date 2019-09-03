<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PacoteEspecial.aspx.cs" Inherits="PacoteEspecial" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE HTML>
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
    fbq('track', 'Lead');
</script>

<noscript><img height="1" width="1" style="display:none"
  src="https://www.facebook.com/tr?id=166866353880804&ev=PageView&noscript=1"
/></noscript>
<!-- End Facebook Pixel Code -->
<html>

<head id="Head1" runat="server">
<title>
<%
Pacote pc = new Pacote();
pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
Response.Write(pc.Titulo.ToString());  %>


</title>
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

    <style type="text/css">

br {clear: none;}
        .style1
        {
            font-size: xx-large;
        }
    </style>
<link rel="shortcut icon" href="http://www.tbviagens.com.br/img/favoicon.ico" />
</head>
<body>

	<!--start-home-->
	<div id="home" class="header">
		<div class="header-top">
			<div class="container">
				<div class="logo">
					<img src="imagens/Logo.png" class="img-responsive"/>
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
	 <div class="banner two">
		 <div class="container">
		    <h2 class="second">
             <%   
                 Pacote pc = new Pacote();
                 pc.Carregar(int.Parse(Request.QueryString["CD_PACOTE"].ToString()));
                Response.Write(pc.Titulo.ToString());          
               %></h2>
		 </div>
     </div>
</div>
<!--single-->
	<div class="single">
		<div class="container">		
				<div class="single-top">
					<img  src="pacote/<% Response.Write( Request.QueryString["CD_PACOTE"].ToString() + "/" + pc.CaminhoImagem1 ); %>" alt=""/>
                   

				</div>
				<div class="top-single">
				<h4>
                <% Response.Write(pc.Resumo); %>
                </h4>
			    <p class="eget">
                <% Response.Write(pc.Detalhe); %>
                </p> 
		</div>
<!--/contact-->
	 <div class="section-contact">
	    <div class="container">
				<div class="contact-main">
					<div  class="tip-main">
    <form id="form2" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

                   <h4 class="style1">Para fazer sua cotação preencha o formulário
    </h4>

   

    <table align="center" class="style3">

            <tr>
            <td>
                <strong>
    Dados Pessoais</strong></td>
        </tr>
        <tr>
            <td>
    <asp:Label ID="lblNomeCompleto" runat="server" Text="Primeiro Nome ou Apelido"></asp:Label>
&nbsp;<span class="style1" style="color: rgb(255, 0, 0)">*</span></td>
        </tr>
        <tr>
            <td>
    <asp:TextBox ID="txtNomeCompleto" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
    <span class="style1">&nbsp;<span style="color: rgb(255, 51, 0)">*</span></span></td>
        </tr>
        <tr>
            <td>
    <asp:TextBox ID="txtEmail" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    <asp:Label ID="lblCelular" runat="server" Text="Telefone"></asp:Label>
    <span class="style1">&nbsp;<span style="color: rgb(255, 51, 0)">*</span></span></td>
        </tr>
        <tr>
            <td>
    <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
   
            </td>
        </tr>
        <tr>
            <td>
            <hr>
            <br>

    
                   <br />
                <IMG height="30" alt="" src="Captcha.aspx" ></td>
        </tr>
        <tr>
            <td>
    
    <asp:Label ID="Label1" runat="server" 
        Text="Digite o número apresentado na imagem acima"></asp:Label>

    &nbsp;<span class="style1" style="color: rgb(255, 51, 0)">*</span></td>
        </tr>
        <tr>
            <td>
    <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    <span class="style1"><span style="color: rgb(255, 51, 0)">Campos obrigatórios *</span></span></td>
        </tr>
        <tr>
            <td>
                <span class="style1"><table style="width:100%;">
        <tr>
            <td style="width: 133px">
            <div class=send>
    <asp:Button ID="BtnCotacao" runat="server" 
    Text="Solicitar Cotação" onclick="BtnCotacao_Click" /></div>
            </td>
            <td>
    <span class="style1">
    <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
    </span>
            </td>
        </tr>
    </table>
    </span>
            </td>
        </tr>
    </table>
    </form>
					</div>
			      </div>
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

		<div class="copy">
		   <p>TBViagens | Av. Eng. George Corbisier, 1692 – Sala 01 - Jabaquara – São Paulo/SP CEP: 04345-001 | Telefone: (011) 2305-3530 | E-mail: tbviagens@tbviagens.com.br <br> TB Agência de Viagens e Turismo LTDA | Tbviagens LLC | CNPJ: 17.325.345/0001-18 | CADASTUR: 26.057043.10.0001-6 </p>
		</div>
		<!--footer-->
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

<script type="text/javascript" src="http://leadlovers.com/scripts/llpixel.js"></script>
<script type="text/javascript">    llpixelRequest('8FBF0FAC9A');</script>

</body>
</html>