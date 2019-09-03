<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UltimoCaptcha.aspx.cs" Inherits="UltimoCaptcha" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html lang="it" xml:lang="it" xmlns="http://www.w3.org/1999/xhtml">
<head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8" /><title>
	Prenota OnLine
</title><link rel="Stylesheet" type="text/css" href="App_Themes/acc_Client_general.css" /><link rel="Stylesheet" type="text/css" href="App_Themes/acc_Common.css" /><link rel="Stylesheet" type="text/css" href="App_Themes/acc_Stampa.css" media="print" />
    <link rel="Stylesheet" type="text/css" href="App_Themes/acc_Calendario.css" />
<link rel="shortcut icon" href="images/favicon.ico" /></head>
<body>
    <form method="post" action="https://prenotaonline.esteri.it/acc_Prenota.aspx" id="aspnetForm">
<div>
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="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" /><input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="NS+GkmT/aAuHnUAXspN+EtGDTmflonPEKFiXr2Ii8eat24bsavkCOrjlzImT0PcUEWBSqYAaOAqQ7G3o7HL236r95uV/9cDtvFNQezeimPPlx8BZ0YTqzjLMSIUUU975wuQU1KIHk+vbqgt1nw1gv9eIXSo=" />
</div>

    <div id="wrapper">
        <div id="header">
            <div class="left_header">
                </div>

            <ul class="hidden">
                <li><a href="#rightcolumn" accesskey="c" title="Vai al contenuto di questa pagina">Contenuto
                    della pagina</a> (accesskey: c)</li>
                <li><a href="#menu" accesskey="m" title="Vai al menu pricipale">Menu</a>
                    (accesskey: m)</li>
            </ul>
            <ul id="topinfo">
                <li>Utente&nbsp;<asp:Label ID="ctl00_lblUserName" runat="server" Text="bml@ig.com.br"></asp:Label></li>
                <li>Id &nbsp;<asp:Label ID="ctl00_lblIdCittadino" runat="server" Text="2286035"></asp:Label></li> 
                <li>Richieste in corso&nbsp;<span id="ctl00_lblRichieste" class="grassetto">0</span></li>
            </ul>
        </div>

                    <div class="headerGrid">
                <div class="center_header_grid">
                    Legalizzazione certificati, Data selezionata
                    <asp:Label ID="ctl00_ContentPlaceHolder1_lblDataSelezionata" runat="server" Text="20/05/2016"></asp:Label>
                </div>
            </div>  
        <div id="rightcolumn">
            
    
            <div class="headerGrid">
                <div class="center_header_grid">
                    
                    <span id="ctl00_ContentPlaceHolder1_lblConfermiLaPrenotazione">Confermi la richiesta di prenotazione?</span>
                </div>
            </div>
            <div id="ctl00_ContentPlaceHolder1_panelCaptcha" style="margin-left:15px">
	
                <br />
                <label for="ctl00_ContentPlaceHolder1_captchaConf" id="ctl00_ContentPlaceHolder1_LblCaptConf">Inserire il codice di verifica visualizzato nell'immagine:</label>
                <br />
                <img id="ctl00_ContentPlaceHolder1_confCaptcha" title="Codice di verifica" class="confCaptcha" src="http://tbviagens.com.br/captcha.aspx" alt="Codice di verifica" style="border-width:0px;" /><br />
                <br />
                <input name="ctl00$ContentPlaceHolder1$captchaConf" type="text" id="ctl00_ContentPlaceHolder1_captchaConf" title="Codice di Verifica" class="captchaConf" style="width:204px;" />
                
            
</div>
            <div> 
                
                <input type="submit" name="ctl00$ContentPlaceHolder1$btnFinalBack" value="Annulla" id="ctl00_ContentPlaceHolder1_btnFinalBack" title="Annulla" class="inputButton btnFinalBack" />
                <input type="submit" name="ctl00$ContentPlaceHolder1$btnFinalConf" value="Conferma" id="ctl00_ContentPlaceHolder1_btnFinalConf" title="Conferma" class="inputButton btnFinalConf" />
            </div>
        

        </div>
    </div>
    
<div>

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="330D65DD" />
	<input type="hidden" name="__VIEWSTATEENCRYPTED" id="__VIEWSTATEENCRYPTED" value="" />
	
</div></form>
</body>
</html>