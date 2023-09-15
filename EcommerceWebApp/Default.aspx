<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcommerceWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-commerce</title>
    <link rel="stylesheet" type="text/css" href="styles.css" /> <!-- Includi il tuo file CSS -->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptArticoli" runat="server">
                <ItemTemplate>
                    <div class="prodotto">
                        <img src="<%# Eval("Immagine") %>" alt="<%# Eval("Nome") %>" />
                        <h2><%# Eval("Nome") %></h2>
                        <p><%# Eval("Prezzo", "{0:C}") %></p>
                        <a href='<%# "DettaglioArticolo.aspx?id=" + Eval("Id") %>'>Dettagli</a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
