using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceWebApp
{
    namespace EcommerceWebApp
    {
        public partial class Carrello : System.Web.UI.Page
        {
            public class Articolo
            {
                public int Id { get; set; }
                public string Nome { get; set; }
                public decimal Prezzo { get; set; }
            }

            private static List<Articolo> ArticoliNelCarrello { get; set; } = new List<Articolo>();

            public static void AggiungiAlCarrello(Articolo articolo)
            {
                ArticoliNelCarrello.Add(articolo);
            }

            public static void RimuoviDalCarrello(Articolo articolo)
            {
                ArticoliNelCarrello.Remove(articolo);
            }

            public static void SvuotaCarrello()
            {
                ArticoliNelCarrello.Clear();
            }

            public static List<Articolo> GetArticoliNelCarrello()
            {
                return ArticoliNelCarrello;
            }

            public static decimal CalcolaTotaleCarrello()
            {
                decimal totale = Carrello.CalcolaTotaleCarrello();
                return totale;
            }
        }
    }
}