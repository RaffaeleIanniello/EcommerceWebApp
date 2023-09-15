using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebApp
{
    public static partial class Carrello
    {
        public static List<Articolo> ArticoliNelCarrello { get; set; } = new List<Articolo>();

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
    }
}