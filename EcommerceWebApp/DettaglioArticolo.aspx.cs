using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceWebApp
{
    public partial class DettaglioArticolo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idArticolo;
                if (int.TryParse(Request.QueryString["id"], out idArticolo))
                {
                    Articolo.Selezionato = GetArticoloById(idArticolo);
                    if (Articolo.Selezionato != null)
                    {
                        DataBind();
                    }
                }
            }
        }

        private Articolo GetArticoloById(int id)
        {
            
            List<Articolo> listaArticoli = new List<Articolo>
    {
            new Articolo(1, "Figurina Del Piero", "attaccante juventus", 10.99m, "file:///C:/Users/devou/Downloads/delpiero.jpg"),
            new Articolo(2, "Figurina Buffon", "portiere juventus", 15.99m, "file:///C:/Users/devou/Downloads/buffon.jpg"),
            new Articolo(3, "Figurina Trezeguet", "attaccante juventus", 7.99m, "file:///C:/Users/devou/Downloads/trezeguet.jpg"),
            new Articolo(4, "Figurina Nedved", "centrocampista juventus", 7.99m, "file:///C:/Users/devou/Downloads/nedved.jpg"),
            new Articolo(5, "Figurina Davids", "centrocampista juventus", 7.99m, "file:///C:/Users/devou/Downloads/davids.jpg"),
            new Articolo(6, "Figurina Cannavaro", "difensore juventus", 7.99m, "file:///C:/Users/devou/Downloads/cannavaro.jpg"),
            new Articolo(7, "Figurina Chiellini", "difensore juventus", 7.99m, "file:///C:/Users/devou/Downloads/chiellini.jpg"),
            new Articolo(8, "Figurina Ronaldo", "attaccante juventus", 7.99m, "file:///C:/Users/devou/Downloads/ronaldo.jpg"),

    };

            
            Articolo articolo = listaArticoli.FirstOrDefault(a => a.Id == id);

            return articolo;
        }

        protected void BtnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            if (Articolo.Selezionato != null)
            {
                Carrello.AggiungiAlCarrello(Articolo.Selezionato);
                Response.Redirect("Carrello.aspx");
            }
        }
    }
}