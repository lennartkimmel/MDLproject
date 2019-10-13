using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDLproject.Models
{
    public class Format
    {
        public int FormatID { get; set; }
        public int StandardID { get; set; }
        public string Modern { get; set; }
        public string Legacy { get; set; }
        public string Vintage { get; set; }
        public string Limited { get; set; }
        public string Commander { get; set; }
        public string Constructed { get; set; }
        public string SealedDeck { get; set; }
        public string Traditional { get; set; }
        public string Advanced { get; set; }

        public Standard Standard { get; set; }
        // This is a navigation property that holds other entities that are related to this entity
        public List<Deck> Decks { get; set; }

       // public int DeckId { get; set; }
       // public Deck Deck { get; set; }
    }
}
