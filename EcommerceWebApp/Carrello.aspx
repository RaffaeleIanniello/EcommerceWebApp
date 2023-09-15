<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="EcommerceWebApp.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Carrello</title>
    <link rel="stylesheet" type="text/css" href="styles.css" /> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptCarrello" runat="server">
                <ItemTemplate>
                    <div class="carrello-prodotto">
                        <h2><%# Eval("Nome") %></h2>
                        <p><%# Eval("Prezzo", "{0:C}") %></p>
                        <asp:Button ID="btnRimuoviDalCarrello" runat="server" Text="Rimuovi" OnCommand="btnRimuoviDalCarrello_Command" CommandArgument='<%# Eval("Id") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="btnSvuotaCarrello" runat="server" Text="Svuota Carrello" OnClick="btnSvuotaCarrello_Click" />
           <asp:Label ID="lblTotale" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
