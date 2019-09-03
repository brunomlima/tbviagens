<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Obrigado.aspx.cs" Inherits="Obrigado" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE HTML>
<html>
<head id="Head1" runat="server">
<title>Obrigado</title>
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
            color: #66CCFF;
        }
    </style>
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
    fbq('track', 'CompleteRegistration');
</script>
<noscript><img height="1" width="1" style="display:none"
  src="https://www.facebook.com/tr?id=166866353880804&ev=PageView&noscript=1"
/></noscript>

<!-- End Facebook Pixel Code -->
</head>
<body>
	<!--start-home-->
	<div id="home" class="header">
		<div class="header-top">
			<div class="container">
				<div class="logo">
					<a href="Default.aspx"><img src="imagens/Logo.png" class="img-responsive"/></a>
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
		    <h2 class="second">Obrigado por cotar conosco </h2>
		 </div>
     </div>
</div>
<!--start-about-->
    <form id="form1" runat="server">
   <div class="about">
    <div class="container">
	    <h3 class="tittle few">Sua cotação foi enviada com sucesso!</h3>
		<div class="about-top">
					<div>
						<h4>Olá,
                            <asp:Label ID="lblNome" runat="server"></asp:Label>
                        </h4>
                        <h4>&nbsp;Meu nome é Priscila, faço parte da <b>TBViagens</b> e fiquei muito feliz pelo seu contato. :) <br/><br/>
                            Estamos preparando sua solicitação e em breve 
                            receberá as informações no e-mail cadastrado.</h4>
                        <h4 class="style1"><strong>Acabamos de lhe enviar um e-mail de confirmação este e-mail tem o objetivo apenas 
                            de verificar se nossos e-mails NÃO estão caindo em sua caixa de SPAM, se tiver, 
                            por favor marcar como não SPAM, ok?</strong></h4>
                        <h4>Enquanto aguarda nossa cotação, acompanhe a gente nas redes sociais:<a href='http://www.tbviagens.com.br/blog/'> Blog</a>, <a href='https://www.facebook.com/tbviagens'> Facebook</a>, <a href='https://www.youtube.com/channel/UC-tTX62jaV8wH7fx-kp7A0g'>Youtube</a> e <a href='https://www.instagram.com/tbviagens/'>Instagram</a>! <br/><br/>
                        Um abraço <br/><br/><br/>
                            Priscila</h4>
					</div>
				</div>
        </div>
     </div>
	<!--start-services-->
   <!-- service-type-grid -->
	<div class="service-type-grid">
		<div class="container">
		    <h3 class="tittle">Nossos Serviços</h3>
			<section class="slider">
				<div class="flexslider">
					<ul class="slides">
						<li>
							<div class="service-type-grd-info">
							  
								 <div class="col-md-6 service-type-main">
										<div class="service-type-grd-left">
											<img src="imagens/10.jpg" alt=" " class="img-responsive" />
											<h5></h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/12.jpg" alt=" " class="img-responsive" />
											<h5></h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/13.jpg" alt=" " class="img-responsive" />
											<h5></h5>
										</div>
								     </div>
									<div class="col-d-6 service-type-grd-right">
           								<h3>Passagens aéreas</h3>
										<h4>Garantia de menor preço.</h4>
										<p>Reserva e emissão de passagens aéreas nacionais e internacionais com entrega imediatamente após sua solicitação;</p>
										<h3>Cruzeiros</h3>
										<h4>Receba dicas de quem já foi.</h4>
										<p>Reserva e emissão de bilhetes de cruzeiros;</p>
                                    </div>
									<div class="clearfix"> </div>
								</div>
						</li>
						<li>
							<div class="service-type-grd-info">
							  
								 <div class="col-md-6 service-type-main">
										<div class="service-type-grd-left">
											<img src="imagens/11.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/14.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/15.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
								     </div>
								<div class="col-d-6 service-type-grd-right">
										<h3>Pacotes turísticos</h3>
										<h4>PESQUISAMOS PARA VOCÊ NAS MELHORES OPERADORAS DO MERCADO</h4>
										<p>Para os mais variados destinos e perfis, nacionais e internacionais;</p>		
                                        <h3>Hotéis</h3>
										<h4>Utilizamos o melhor buscador de hotéis do mercado.</h4>
										<p>Reserva de hotéis em todas as categorias, no Brasil e no exterior, com tarifas direfenciadas, garantidas por acordos comerciais com nossos parceiros;</p>	    
									</div>
									<div class="clearfix"> </div>
								</div>
						</li>
						<li>
							<div class="service-type-grd-info">
							  
								 <div class="col-md-6 service-type-main">
										<div class="service-type-grd-left">
											<img src="imagens/17.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/18.jpg" alt=" " class="img-responsive" />
												<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/16.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
								     </div>
								<div class="col-d-6 service-type-grd-right">
										<h3>Locação de veículos</h3>
										<h4>Temos parcerias com todas as empresas Movida, Localiza, Rental Cars, etc.</h4>
										<p>Reserva de veículos, no Brasil e no exterior, com tarifas diferenciadas por meio de acordos corporativos;</p>
                                        <h3>Documentação</h3>
										<h4>Já prestamos assistência para mais de 200 pessoas.</h4>
										<p>Assistência personalizada para a obtenção de passaportes e vistos;</p>
									</div>
									<div class="clearfix"> </div>
								</div>
						</li>
                        <li>
							<div class="service-type-grd-info">
							  
								 <div class="col-md-6 service-type-main">
										<div class="service-type-grd-left">
											<img src="imagens/19.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/22.jpg" alt=" " class="img-responsive" />
												<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/21.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
								     </div>
								<div class="col-d-6 service-type-grd-right">
										<h3>Seguros</h3>
										<h4>Nós vamos garantir uma viagem segura.</h4>
										<p>Efetuamos todos os procedimentos para que o cliente junto as seguradoras;</p>
                                        <h3>Receptivos e traslados</h3>
										<h4>Não se preocupe alguém estará lhe aguardando.</h4>
										<p>Para comodidade de nossos clientes trabalhamos com traslados aeroporto-hotel e hotel-aeroporto, principalmente para cadeirantes;</p>
									</div>
									<div class="clearfix"> </div>
								</div>
						</li>
                        <li>
							<div class="service-type-grd-info">
							  
								 <div class="col-md-6 service-type-main">
										<div class="service-type-grd-left">
											<img src="imagens/26.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/25.jpg" alt=" " class="img-responsive" />
												<h5> </h5>
										</div>
										<div class="service-type-grd-left">
											<img src="imagens/27.jpg" alt=" " class="img-responsive" />
											<h5> </h5>
										</div>
								     </div>
								<div class="col-d-6 service-type-grd-right">
										<h3>Faturamento simplificado</h3>
										<h4>Facilitamos ao máximo para que sua viagem caiba no seu orçamento.</h4>
										<p>O prazo de faturamento de nossos serviços é acertado conforme a necessidade de cada cliente. Mais comodidade e adequação à sua agenda financeira;</p>
                                        <h3>Serviços em aeroportos</h3>
										<h4>Assistência para embarque e desembarque</h4>
										<p>Este serviço funciona 24h por dia, mediante agendamento;</p>
									</div>
									<div class="clearfix"> </div>
								</div>
						</li>
					</ul>
				</div>
			</section>
			<!--FlexSlider-->
						<script defer src="js/jquery.flexslider.js"></script>
							<script type="text/javascript">
							    $(function () {
							        SyntaxHighlighter.all();
							    });
							    $(window).load(function () {
							        $('.flexslider').flexslider({
							            animation: "slide",
							            start: function (slider) {
							                $('body').removeClass('loading');
							            }
							        });
							    });
					</script>
			<!--End-slider-script-->
		</div>
	</div>
		<!--testimonials-->
		<div class="testimonials" id="test">	
			<div class="container">
				<h3 class="tittle three">Testemunhos</h3>
                <% ShowTestemunho.Show(); %>
					</div>
				</div>
		<!--//testimonials-->
   <!--contact-->
		<div class="contact" id="contact">
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
    <div>
    
    </div>
    </form>
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