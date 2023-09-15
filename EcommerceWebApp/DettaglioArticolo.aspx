<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DettaglioArticolo.aspx.cs" Inherits="EcommerceWebApp.DettaglioArticolo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dettaglio Articolo</title>
    <link rel="stylesheet" type="text/css" href="styles.css" /> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="dettaglio-prodotto">
                <img src="<%# Articolo.Selezionato.Immagine %>" alt="<%# Articolo.Selezionato.Nome %>" />
                <h2><%# Articolo.Selezionato.Nome %></h2>
                <p><%# Articolo.Selezionato.Descrizione %></p>
                <p><%# Articolo.Selezionato.Prezzo.ToString("C") %></p>
                <asp:Button ID="btnAggiungiAlCarrello" runat="server" Text="Aggiungi al Carrello" OnClick="btnAggiungiAlCarrello_Click" />
            </div>
        </div>
    </form>
</body>
</html>
