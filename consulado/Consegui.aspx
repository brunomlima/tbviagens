<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Consegui.aspx.cs" Inherits="Consegui" %>




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
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="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" /><input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="1EOuVIlAYk0pBk47tC/2z38X7RMBuuZok6doIygau29hte4b9FgvO+xH9B/N8vg61P1fVuODbxGt426bB7++ZO098hRjW68HxjGAR/uYArVQhC1A5dMtLjzV+d9fWAbORjEPC/gdgYZip+zn5FSqi6FgW2M=" />
</div>

    <div id="wrapper">
        <div id="header">
            <div class="left_header">
                </div>
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
                    <asp:Label ID="ctl00_ContentPlaceHolder1_lblDataSelezionata" runat="server"></asp:Label>
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

<div id="calendar">
        <span id="ctl00_ContentPlaceHolder1_acc_Calendario1_myCalendario1" class="calendario"><table class="calendario" summary="Summary" cellspacing="0"><caption>Calendario eventi</caption><tr class="calTitolo">
	<th><input type="submit" name="ctl00$ContentPlaceHolder1$acc_Calendario1$myCalendario1$ctl01" value="&lt;" title="Clicca qui per andare al mese precedente" class="pulsanteCalendario" /></th><th colspan="5"><span>giugno, 2016</span></th><th><input type="submit" name="ctl00$ContentPlaceHolder1$acc_Calendario1$myCalendario1$ctl03" value=">" title="Clicca qui per andare al mese successivo" class="pulsanteCalendario" /></th>
</tr><tr>
	<th class="calDayHeader" scope="col">lun</th><th class="calDayHeader" scope="col">mar</th><th class="calDayHeader" scope="col">mer</th><th class="calDayHeader" scope="col">gio</th><th class="calDayHeader" scope="col">ven</th><th class="calDayHeader" scope="col">sab</th><th class="calDayHeader" scope="col">dom</th>
</tr><tr>
	<td title="Giorno non disponibile" class="otherMonthDay">30</td><td title="Giorno non disponibile" class="otherMonthDay">31</td><td title="Tutto occupato" class="calendarCellRed">1</td><td title="Giorno non disponibile" class="cellaSelezionata">2</td><td title="Giorno non disponibile" class="noSelectableDay">3</td><td title="Giorno non disponibile" class="noSelectableDay">4</td><td title="Giorno non disponibile" class="noSelectableDay">5</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">6</td><td title="Giorno non disponibile" class="noSelectableDay">7</td><td title="Giorno non disponibile" class="noSelectableDay">8</td><td title="Giorno non disponibile" class="noSelectableDay">9</td><td title="Giorno non disponibile" class="noSelectableDay">10</td><td title="Giorno non disponibile" class="noSelectableDay">11</td><td title="Giorno non disponibile" class="noSelectableDay">12</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">13</td><td title="Giorno non disponibile" class="noSelectableDay">14</td><td title="Giorno non disponibile" class="noSelectableDay">15</td><td title="Giorno non disponibile" class="noSelectableDay">16</td><td title="Giorno non disponibile" class="noSelectableDay">17</td><td title="Giorno non disponibile" class="noSelectableDay">18</td><td title="Giorno non disponibile" class="noSelectableDay">19</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">20</td><td title="Giorno non disponibile" class="noSelectableDay">21</td><td title="Giorno non disponibile" class="noSelectableDay">22</td><td title="Giorno non disponibile" class="noSelectableDay">23</td><td title="Giorno non disponibile" class="noSelectableDay">24</td><td title="Giorno non disponibile" class="noSelectableDay">25</td><td title="Giorno non disponibile" class="noSelectableDay">26</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">27</td><td title="Giorno non disponibile" class="noSelectableDay">28</td><td title="Giorno non disponibile" class="noSelectableDay">29</td><td title="Giorno non disponibile" class="noSelectableDay">30</td><td title="Giorno non disponibile" class="otherMonthDay">1</td><td title="Giorno non disponibile" class="otherMonthDay">2</td><td title="Giorno non disponibile" class="otherMonthDay">3</td>
</tr></table></span>
    </div>
    <div id="Div1" >
        <input type="hidden" name="ctl00$ContentPlaceHolder1$acc_Calendario1$HiddenField1" id="Hidden1" />
        
    </div>
</div>




    <div id="orari" >
        <input type="hidden" name="ctl00$ContentPlaceHolder1$acc_Calendario1$HiddenField1" id="ctl00_ContentPlaceHolder1_acc_Calendario1_HiddenField1" value="14408" />
        
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
                        
                        <span id="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_lblColoreFascia" style="color:#058D08;background-color:#058D08;">  &nbsp</span>
                        <label for="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_btnConferma" id="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_lblFascia">08:30 - 11:30</label><br />
                        
                    </td>
                    <td>
                        <input type="submit" name="ctl00$ContentPlaceHolder1$acc_Calendario1$repFasce$ctl01$btnConferma" value="Conferma" id="ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_btnConferma" title="Conferma" class="inputButton" />
                    </td>
                </tr>
            
                </table>
            
    </div>
</div>

            <input type="submit" name="ctl00$ContentPlaceHolder1$lnkBack" value="Annulla" id="ctl00_ContentPlaceHolder1_lnkBack" title="Indietro" class="inputButton btnBack" />
            <a id="ctl00_ContentPlaceHolder1_hlEsteri" href="http://www.esteri.it/MAE/IT/Ministero/LaReteDiplomatica/Ambasciate/?Cod=2630203" target="_blank">Contatti</a>
        

        </div>
        <div id="footer">
            
        </div>
    </div>
    
<div>

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="330D65DD" />
	<input type="hidden" name="__VIEWSTATEENCRYPTED" id="__VIEWSTATEENCRYPTED" value="" />
	
</div></form>
</body>
</html>
