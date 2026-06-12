using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Produits
    {
        public string Nom { get; set; }
        public string Marque { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public bool Cassable { get; set; }

        public Produits(string nom, string marque, double prix, int quantite, bool cassable)
        {
            Nom = nom;
            Marque = marque;
            Prix = prix;
            Quantite = quantite;
            Cassable = cassable;
        }

        public override string? ToString()
        {
            return $"Nom: {Nom} Marque: {Marque} Prix: {Prix}, Quantite {Quantite}, Cassable :{Cassable}";
        }
    }
}
