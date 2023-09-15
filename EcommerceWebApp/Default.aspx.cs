using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace EcommerceWebApp
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptArticoli.DataSource = GetArticoli();
                rptArticoli.DataBind();
            }
        }

        private List<Articolo> GetArticoli()
        {
            
            List<Articolo> articoli = new List<Articolo>
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

            return articoli;
        }
    }
}
