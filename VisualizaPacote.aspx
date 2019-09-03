<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VisualizaPacote.aspx.cs" Inherits="VisualizaPacote" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE HTML>
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
            font-family: Arial, Helvetica, sans-serif;
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
        <div align="center">
	<h4 class="style2"> <a href="Reservar.aspx?DESTINO=<%Response.Write(pc.Titulo.ToString()); %>"> 
        
        <img src="img/BotaoReservarPacote.png" style="text-align: center"></a></h4>
            <span class="style1">
        <b><font color="#98C13B"> TB</font><font color="#6EB1C0">Viagens! </font></b>
            <font color="#000000" style="">Transformando pequenos instantes em grandes e inesquecíveis momentos.</font></span>
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


</body>
</html>