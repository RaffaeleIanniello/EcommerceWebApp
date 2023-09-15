using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWebApp
{
    public class Articolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string Immagine { get; set; }
        public static Articolo Selezionato { get; set; }


        public Articolo(int id, string nome, string descrizione, decimal prezzo, string immagine)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Immagine = immagine;
        }
    }

}
