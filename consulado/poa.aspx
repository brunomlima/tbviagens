<%@ Page Language="C#" AutoEventWireup="true" CodeFile="poa.aspx.cs" Inherits="poa" %>




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
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="mcnoD4+hQ1zCi44z3cw+f1kGxMP/pHQ1Uhz/EziI8GIiHkjE5o9TTwHPvoXz68SCeKKMdXLKbAG8jp3l8ExcRDpecXWciwyZg3Bij/SNuZWc78yq/t4+lD1nWaNsBEpRv+m23ah6sAWG5HoJYioW/O+PdQUUHcsKjnlhrOXzHoM12jO7yvqOdc1traAdka9ctM0B4sxuoeDbMvawidW6P1SAHi9GBBpoY9H9pPy2pA0mmoebwYy7IsBzWR5b0LAL7RFMsZ9TiOSmA7BiYa+t5uYIcmQSGXEA0HfEg+SbeAKPu3dzsvELJD0jMMQ4fVblU/slLR1YCMYEeXAEbhaEHV+KqlH9DBoWFw0FYePov6EiWgNpbLBgYpLsmn/CurH4Msl9+QduZen7THDYGOyX3VX7dN/QKPzL3P8R741L517YpKrbu8KeyP2cXRMdI32UQ6N7t1ZcKFdawQEApAjtFx3jSlGxvfja8AhICh4GzU6WjhzN/5jQx3tyIcyBKuF/7YXEWwV9vrq8rYMps1x/SzsOpRFafsvP13VDbkdchN6HBYTLj+ypYMfWVbHVOh7aHeF3ChLHf+MzlwXB6QZeK23C0JcrpDneiymwN/EafOoUk+svJcjArrwgKFoMdfwODZiCI7y5AK61mq+2kLPM16HrYVhuNBPaVd88XBab6H+JnN8ZCyd8OM3NlfqH1t+uw4dTXGosP0XdUmyP2rMBVM1jWKXJoTjfo5AsEx7qInwjPyeEjhjBHTCr32OXGT4sGRWmH5Dw6DHNpgRSlJD+sEhINPaQBH7yXqRW+OsnpGij6N7cJX7j9/Ks2D5oWNGsDgn5BCI1gYv1pHhq1seWpQSfkat1s6Ni7nlLq69iy2Lb2IXAiEqL8baaWUwXeXRhh0l5SjySYFKgTYxBU9l747vMNWP89JW8JR/881etQHURNBdA/U2uauROPr6Y+JXTlVs0oryOOWKaroUoPCKDMyBdvsoMGzmSf83vZlvy4EpKhUCkY0OvSBQHX9h2G5ScHenL7JqmE6FVQOiiEy4VTif6AHndsxEd5DNgrKh26GcH7QaZYebEGc1wRglUTof0CTPsZIL8b53GXa0UXhInw6+CCwxaP5UFC9wTwf54ZhoS7reVE4B4Zj+YTOJoBku5B6xzhM47+9hwxUQ94qUlh+WVN+ffTXEJlkzH8X4CKzTQ12hW6T/WQ0rSw4BE/vgcSGjy2MdhFzyeSYdOA6S5DaK7b7Fm3tOZUAWPL0B+77iV6+e0i02kXgszKm3H6RRq5Nt8gHeXAy9AYq50S0pS1JzpS0bH5WZ6gUmLPM5qW/C6TV+2Efa0Ly6Mckr4iN50xhlOsVwncim1hIHJCyPfU/0qRhr3ZkeUhhpJTTZPca9YlFGAqkFtY+9LhAXpWjKoaC4eeRwQug4ZPh4jiXifeWiVVJN5vpaZshHMKSlLFB4gEfchHQbc6dmwa/BTdRKhjmiokBJG9N1pVqwNtH2VjQm+A5BlZrAelAdhyc7gI1WNXidCLyW/B1JdWmaOyZy+YR1fpS+UeET7VZ7bpro+kjnw0hRHXKjJY16pCwIRLE7bUWryPwKQJ7gkv9kqTMYNUdJ0FwK8kyhK42zJFR0rGgu6H9NrtRKvBXttjg8B9Ra5vNWhIbwJJ34dzbgRGq16/MiAh9tSQFqzEYyNiTz1k3DnXImxhSs9RX9zo4RDNe4lIYbGYcuyUIX6QF7dsWgo27NgStHtODvxDCG74GfJ3mwusj5TW5GWxUBz13AJ3JFEbaZ0OCDCHFJqNDOV9Oq0h2XM5WSAy4dQLTonY1KrXWVRnku+08Eq8Aqp+JVV8WYxt6dAl5i/haCZgDtmBCe/yrXNhHfoYIcE2Uxe7z6L1cWY+0rJ6lHxHxvcRd4zyvL2pxfrtRhjlJBLP2Ni+Of39RQS2rxjP9N0m7lvFNkIR9lckl8nn8tWHERQo+ibpGYstMMKGAK6Sgt1K43DT99cTsvUbIqXr33MORo8jKKA4xNSaqhLr0M6R/CpPlO9fQ20r2QvVgfYk88PBVUnnJEcilIDRprRcCFJ/LtjEjJzV8PYlXnz1DPNy/0k2bFzodgmPzAFQp6YCulLZM4jinzy+XOVoMxs5ylANbDZfPYN+s1isYh8aXkIPI9dg2bqG2iIeVJOAgXmKyz1M04+hHcdKeW9FJL4R+ZvnimoigRWbdDdXbi5fhv8knWVpq7tf8MMPT5mKRIeT1vGLsdN7dkWZ/PhEfI3AOKsvZfJYeZeGnLPnFvyfxD1OZkOaB/q1cUzKXh6LYh8JHaoxdb+d0BwatbO9y6ttYI61awQI+Z2r0YekqDXu8oCBl6/9Ej9iRJNBMi8cNXjQkM6jtKEUTexQpJN5YnSGE9W10/aR9UKOMePhGjczrJULt7AA7DpsTn5o3A/VbY8sWmSytriYJuqUo5gRvecrsOjMSBT29SxjfagkFwH4gh5VTTvvtjfgNUTxwx5GxopI2PV4r434FffRJGXFWLcVE4m9SKFJa9nDszEPeB7YaZ2p0cLKGwR+uaYuRYj6v1NfXVz9StHDeaCmc2QJ6NnIFELM5TU7En+XIrXEJQ0ttNrluq1Pn36INxmrLI1AptfaoQOHnfQnjVehB81gaBzCLkEKEtURwIieesd7iVtkFo+9DXtSi+KpO5bbYt4m4l0EVzMJnAqYDxQC+fGSHsgo2PjOhDEBtClfBgk/H6LlyUXMeFhdm2ZcSRBWWXSDUCwBcfaJUPkmmns/Qso6DwTiOYI+kAfsjA8UVGdawZO2K3ZUKR4u5yOPmOz101o/EuLl4chBz8QephtTjh4OToQueifwp86+1Ka0eXeNrCtDxE6fmjKr5d0PtjLsEB/QEwLL3T63/jVgfB5pQ4XnToJvwsUmvC13iCiTlgXIpw362V9bXbPu44CEZUvUwd1mtG+Zuh7Cxg0/E2BxtbMzLE15ok+bzVAkX0rRcGroXyIY64r2HH8ZJmfTGjWScUF0H1yUCgNYEXJQku4fMClDmFZ6RlJyX7lFPOhxWRznoyj7IBLF/Cc+DnbtqntYHmuH6kopSOtx7uuz98YYSmg6RnpBhSLRiNzFte1mSSdL9/Tgo3XYx9HmbC8GIWYk5AOQevE6jrkL9TWtMMdeTmjxeYWLLyMMkg1KuqvlUu7P3c61TnY5yFCLM4geAig0K0E7xpgtKaBlSFuIXFis8sdXy1w4LangpN3ed6o4ICcp0ZL8JrVffdDaYB7rUSUxGvb+zonqxeJQscKAtw6ozkiKqT6FQ312Ciksdl+c0Ft+X1t2eiLX0/k2NSTafplBsUqnVhoclPb9BRvvwT/BUSSNFXtg1i1y9yCgwyvky4WbrUoZIE9yXVNzKHmCt/DZtXAmNzvQtKyXd4nArWSsGU6aR64v7QRZZaRowsHT0MG35pyZyonnTrNV8avzfwpIS7VaQI/qWDugnkAo8U50mM7ru1o0Ux7yIQJKZbkdwSms9sNNXpYUCRWtCdDGTsszb6ZO6XBhzIF5TlGyA83wvEu2xmCuxNmWp3aAVyqo/s4jRxQw7LDhwPfrH0WUR1FR/zHpups9fKWSGuHQZa3dj8V2nhSywIWl/ruw7jim3oGJ74cZ8KeNMj15ht3U8Jnnfb185HBJLz19Cx0d0VbOgLpgHpTrbgSUeAFMQ7cIYDOJt+KU14sBmlZLoZknTvcpWN+704EDh5trVfPX4h5ywr9OTBVz6BQQYbc8QnrAjBkLdd+MJe3qmlKNxNLa3dMP+WsZWTdVR0CtQ7xWQIuhb35j7WSU1FT9pnxjC37RgvqwjwhwVIM+aF34lI5ULL2zQgXdk4jhcLmeWYgJ3D4X77GFFOrBwIphwc6BPjK3rE6tUvVTF+SHYY/LCjOhad8mGrlg1svLW61WLz38fuwmOyQbKR47j+CHogdc41M14QDfggq0CsFxAFIuNuHTyi371oC9ZuFynY90oDJSb+eI93YUjyUsSnaPkOX9pCO/Fqe3ID91iJryB3bt0K5FKalkInhCb42DRtir2v0tudC4JPe47VsBfR+RrB3sq68fGdWUMXsgakS7tXrBJwVcfR+hSseUirzV3KIAdB/ASKLBrUi7bdKONI/+d5qybKJBZ3CKOztXDfXPvJVt2I2plEa3gbc+S/4el5/tWP4cBg7JDOu74pd0AiCDXUieevVQX9uWFEy+KOY+izNOikP6HiZDy+0laHG0/MegPVIu3h5gO2lqgQS+KjUZqZi9pgGyhJvNNSiNt8dgtPMaXdt+2Iqt+r9SLx59Jk6yuowWSJgYkh0KfErF54nlWoMcvbfnmUxdB28CboH0JWfb5McH79Dmos1P3KXnzpLpjs/QuZnnAnoGODUDnupHDnZiYksBRyY3I3bhtQWBaZygpKkZPjGfTt4q7khlN3O0iZsXH0rG04ZslFaAIBR2vA0ZCe3sSxNXgNC0BDQllTZVQpcNwpLMawSfxUoJ7x4/ZXxlWsFT53TvdWKecmAZnxAaXqBieyooxwecUM1zMG6WkHZqREp6T92Gd4g3DUYUmYZ4Xzehi0Df1NOwivUHwFOOHs+TFFY8sbiUFsjqiulxrooK9I71CpzQR0V6oHdVIwVWEWpBDXTtW7J7G3n8l+n81nKVeBupJT2eLos6m+YI7AayHU+lxipB5KTG+4WznAKXkogR42ifOo08FsD8+hDp4C8aMLN3NZLImvYNx5jMjyyOgHj2fpjrhItHtmixE+5DdzpbotLvBv4asorJCAbaBetunj+5BdIK2Buf42pf34ggx1rNlhzNHxuKnmXZU1stO+x0J5+MLtG20ZTRJhwphfMgtMJLJeRDkUigAZqOd6ks/z8cif29TOKGNWC4V2UvvMcgiNbB0b0dUIg0g7RapW03K0X0mWvFhg/zr0r6LITYyX2tSGKKUxhA9aKH1XopUe5JHt/MlTN0LH7B84rvxmYRZx3PsfIGqKwkEilEuecDeFaSa6KD4NI/B1r77LTGOjy/f5sCdbL6LkA2DhNIJ5DqTapI076cpk6vpVVAkqNl6AhGeajNM+ZJx0NUBjWefWv9P92rw7zLljS0OyT4XhRBQXYWGzTlHLwQoHjJ3J0O7iFC/13oUKl0AdmswKqe+i+frIdKx904584VEnyBga/LAjFfkRLNa2IvNJMeoezuUCHAdwKSXpH2Vi0e7wKR3c7OpyaQYd3d/fP/Fhv9QmkLcq2oOXM7D5ONwnfIWOKdwtgzQ1QBcR1aqPVbQSpqrPGsImfIDWPpp/cjv/9LnmgxCDsrMAWn9u1V5OJMDiDPEULxgwJ9RZKnBwN+gdrLZXhcZ8gXlcRmz8tMaX33yHgCD4+qx0NAIALRJbt6r7cCcy0YutUPOv+aF5+fYVfkTcSXDSV1ctglWxv+LMC/dik43JW/w2smmBbQYnyj0SRlGOGHP5duqBiIFKVTeVVfbIx6jhdTW1XcCfvXAltSrKPE2QmkyBIGbrFNeNqcfwaD1hB10XODYq6mHhZQA7veIfnxqLQ1a5AI5hRcSYhPzzarupy8618Zi0MufKN/SzR8B3+ayQHVRbFBhXjG773soqa8/qkbPwDYFhW/JxWzq1mTDwpASx9xFg3+eg7oEtGtWGQQeSGKd8ubdnwkqFb4T7ml2kTx9dLTfp/SEb0zVA0VR738Z47O75ZSUpAs6xpVN0gizhn330UGmlNBgSf6O/+zoWV7c1c8r1rQXfZVcUttmgh9frTOY70cKoWAeVtchzhP9Ss5JyIQIjIx4wE152fMJFqtNH85NmOdT3WI6Nocj/ct8rnJ9QrmpC7wKV5CoppK4PKNnnCUAHgcuZbxct0sPxJeh6/CXPjJbgcStv2q8Ki6Z2QvU5fv2l+WhSyNJ4qnWXTzhwgvdKWIUATjXYIelX9eLj+WsYIFEUuTQRe6QCbxxw=" /><input type="hidden" name="__EVENTVALIDATION" id="__EVENTVALIDATION" value="gorn5SR+r4uOlJWSh7pJ8xUUgLwJ+rS0g2wDKMW56epFokZWwpKwT3Eb3gjKFsKwqtqkBx+mz/MT66Cc8PDN21zc+h/pox56uZhZfp+h+Zec9mWLIQhPzAlI75nmsQLMGE8pmhbkCu+Ou3JGkGU2xcz+eO8=" />
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
                <li>Utente&nbsp;<asp:Label ID="ctl00_lblUserName" runat="server" Text="bofi@leeching.net"></asp:Label></li>
                <li>Id &nbsp;<asp:Label ID="ctl00_lblIdCittadino" runat="server" Text="2517876"></asp:Label></li> 
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
	<th><input type="submit" name="ctl00$ContentPlaceHolder1$acc_Calendario1$myCalendario1$ctl01" value="&lt;" title="Clicca qui per andare al mese precedente" class="pulsanteCalendario" /></th><th colspan="5"><span>luglio, 2016</span></th><th><input type="submit" name="ctl00$ContentPlaceHolder1$acc_Calendario1$myCalendario1$ctl03" value=">" title="Clicca qui per andare al mese successivo" class="pulsanteCalendario" /></th>
</tr><tr>
	<th class="calDayHeader" scope="col">lun</th><th class="calDayHeader" scope="col">mar</th><th class="calDayHeader" scope="col">mer</th><th class="calDayHeader" scope="col">gio</th><th class="calDayHeader" scope="col">ven</th><th class="calDayHeader" scope="col">sab</th><th class="calDayHeader" scope="col">dom</th>
</tr><tr>
	<td title="Giorno non disponibile" class="otherMonthDay">27</td><td title="Giorno non disponibile" class="otherMonthDay">28</td><td title="Giorno non disponibile" class="otherMonthDay">29</td><td title="Giorno non disponibile" class="otherMonthDay">30</td><td title="Giorno non disponibile" class="noSelectableDay">1</td><td title="Giorno non disponibile" class="noSelectableDay">2</td><td title="Giorno non disponibile" class="noSelectableDay">3</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">4</td><td title="Giorno non disponibile" class="cellaSelezionata">5</td><td title="Giorno non disponibile" class="noSelectableDay">6</td><td title="Giorno non disponibile" class="noSelectableDay">7</td><td title="Giorno non disponibile" class="noSelectableDay">8</td><td title="Giorno non disponibile" class="noSelectableDay">9</td><td title="Giorno non disponibile" class="noSelectableDay">10</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">11</td><td title="Giorno non disponibile" class="noSelectableDay">12</td><td title="Giorno non disponibile" class="noSelectableDay">13</td><td title="Giorno non disponibile" class="noSelectableDay">14</td><td title="Giorno non disponibile" class="noSelectableDay">15</td><td title="Giorno non disponibile" class="noSelectableDay">16</td><td title="Giorno non disponibile" class="noSelectableDay">17</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">18</td><td title="Giorno non disponibile" class="noSelectableDay">19</td><td title="Giorno non disponibile" class="noSelectableDay">20</td><td title="Giorno non disponibile" class="noSelectableDay">21</td><td title="Giorno non disponibile" class="noSelectableDay">22</td><td title="Giorno non disponibile" class="noSelectableDay">23</td><td title="Giorno non disponibile" class="noSelectableDay">24</td>
</tr><tr>
	<td title="Giorno non disponibile" class="noSelectableDay">25</td><td title="Giorno non disponibile" class="noSelectableDay">26</td><td title="Giorno non disponibile" class="noSelectableDay">27</td><td title="Giorno non disponibile" class="noSelectableDay">28</td><td title="Giorno non disponibile" class="noSelectableDay">29</td><td title="Giorno non disponibile" class="noSelectableDay">30</td><td title="Giorno non disponibile" class="noSelectableDay">31</td>
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
    
<div>

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="330D65DD" />
	<input type="hidden" name="__VIEWSTATEENCRYPTED" id="__VIEWSTATEENCRYPTED" value="" />
	
</div></form>
</body>
</html>