namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            string reponse= "oui";
            while (reponse.ToLower() != "non")
            {
                //exemple 1
                Console.WriteLine("Entrez votre âge :");
                int age = Int32.Parse(Console.ReadLine());
                string statut = age >= 18 ? "Majeur" : "Mineur";
                Console.WriteLine(statut); // Affiche : Majeur
                                           // Équivalent avec if/else :
                Console.WriteLine("Continuer? oui/non :");
                reponse = Console.ReadLine();
               



        } 
            int[] nombres = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var pairs = nombres.Where(n => n % 2 == 0);
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }
            
            string[] joueurs = ["Ahmed", "Ali", "Sami", "Raja", "Mahmoud", "Khalil"];
            var longNom = joueurs.Where(j => j.Length > 4);
            foreach (string joueur in longNom)
            {
                Console.WriteLine(joueur);
            }
            */
            Produits[] produits = {
                new Produits("pc", "lenovo", 3200, 4, true),
                new Produits("pc", "dell", 4200, 0, true),
                new Produits("flashDisque","traceData",2,20,false)




            };
            Console.WriteLine("liste des produits");
            var productSummary = produits.Select(p => $"{p.Nom} / {p.Marque}");
            foreach(var produit in productSummary)
                Console.WriteLine(produit);
            var cassables = produits.Where(p => p.Cassable);
            Console.WriteLine("liste des produits cassable");

            foreach (var produit in cassables)
                Console.WriteLine(produit.ToString());
        }
        
    }
}
