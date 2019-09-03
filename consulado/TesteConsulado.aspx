﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TesteConsulado.aspx.cs" Inherits="TesteConsulado" %>






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
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="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" /><input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="U9UnfkPwBnm1xotWSk+VYAJ49Sf4YfyFQJhLKbFzdleiWCt04Rm5+tf2nnXYj89Taehqi4nbyBN0/XOcNS/VzHPIgshSQ7vktN/BogqMTMkKz4wBrMJ1qeZCsKK2dmprh1DPuA/gwn78/Ljx1PjOAOpbnSE=" />
</div>

    <div id="wrapper">
        <div id="header">
            <div class="center_header">
                <a href="Default.aspx" title="torna alla Homepage di Prenota OnLine" accesskey="h"
                    tabindex="1">
                    <img id="img_logo" src="images/nuovologo.gif" alt="Servizio di prenotazione OnLine, SICC Ufficio Primo del Ministero Affari Esteri" /></a>                
            </div>

            <div id="sede">
                <h1>Consolato Generale d'Italia a San Paolo</h1>
            </div>

            <ul class="hidden">
                <li><a href="#rightcolumn" accesskey="c" title="Vai al contenuto di questa pagina">Contenuto
                    della pagina</a> (accesskey: c)</li>
                <li><a href="#menu" accesskey="m" title="Vai al menu pricipale">Menu</a>
                    (accesskey: m)</li>
            </ul>
            <br />
            <br />
            <br />
            <ul id="topinfo">
                <li>Utente&nbsp;<asp:Label ID="ctl00_lblUserName" runat="server" Text="bml@ig.com.br"></asp:Label></li>
                <li>Id &nbsp;<asp:Label ID="ctl00_lblIdCittadino" runat="server" Text="2286035"></asp:Label></li> 
                <li>Richieste in corso&nbsp;<span id="ctl00_lblRichieste" class="grassetto">0</span></li>
            </ul>
        </div>
        <div id="rightcolumn">
            
    
            <div class="headerGrid">
                <div class="center_header_grid">
                    Legalizzazione certificati, Data selezionata
                    <asp:Label ID="ctl00_ContentPlaceHolder1_lblDataSelezionata" runat="server" Text="20/05/2016"></asp:Label>
                </div>
            </div>                     
               
            
<div id="calwrapper">
    <div id="legend" style="padding-left:15px; margin-bottom:20px">

        
        <table style="width:90%; border-collapse:collapse; border: 0px">
        <tr style="line-height:15px">
            <td style="background-color:Red; width:80px; margin-right:10px"></td>
            <td style="width: 383px; padding-left:5px">
                Tutto occupato
            </td>
            <td style="background-color:#F09643; width:80px"></td>
            <td style="width: 450px; padding-left:5px">
                Media disponibilit&agrave;
            </td>
            <td style="background-color:#058d08; width:80px">
            </td>
            <td style="width: 383px; padding-left:5px">
                Posti disponibili
            </td>
            <td style="background-color:#000000; width:80px">
            </td>
            <td style="width: 383px; padding-left:5px">
                Non disponibile
            </td>
        </tr>
    </table>
    </div>

    <div id="orari" >
        <input type="hidden" name="ctl00$ContentPlaceHolder1$acc_Calendario1$HiddenField1" id="ctl00_ContentPlaceHolder1_acc_Calendario1_HiddenField1" />
        
                <table id="tblFasce" class="fasce" cellspacing="0" summary="Questa tabella elenca le fasce disponibili per il giorno selezionato. Per confermare la prenotazione fare clic sul pulsante a destra della fascia">
                    <caption>Fasce orarie disponibili</caption>
                    <tr>
                        <th scope="col">
                            Fasce disponibili
                        </th>
                        <th scope="col">
                            Conferma
                        </th>
                    </tr>
            
                <tr>
                    <td>
                        <img id="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_imgStato" src="images/verde.jpg" alt="Posti disponibili" style="border-width:0px;" />
                        <label for="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_btnConferma" id="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_lblFascia">08:30 - 11:30</label><br />
                        
                    </td>
                    <td>
                        <input type="submit" name="ctl00$ContentPlaceHolder1$acc_Calendario1$repFasce$ctl01$btnConferma" value="Conferma" id="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_btnConferma" title="Conferma" class="inputButton" />
                    </td>
                </tr>
            
                </table>
            
    </div>
</div>

            &nbsp;</div>
        <div id="footer">
            <p>
                &nbsp;                
            </p>
        </div>
    </div>
    
<div>

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="330D65DD" />
	<input type="hidden" name="__VIEWSTATEENCRYPTED" id="__VIEWSTATEENCRYPTED" value="" />
	
</div></form>
</body>
</html>