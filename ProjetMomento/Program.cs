namespace MementoDemo
{

    /// <summary>
    /// Program pour la demo du patron memento
    /// </summary>
    class Program
    {
        /// <summary>
        /// Écrire le texte
        /// sauvegarde chaque modification
        /// annule tout(undo)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Editeur editeur = new Editeur();
            Historique historique = new Historique();

            historique.Empiler(editeur.Sauvegarder());
            editeur.Ecrire("Bonjour");
            Console.WriteLine("Texte: " + editeur.LireTexte());

            historique.Empiler(editeur.Sauvegarder());
            editeur.Ecrire(" le monde");
            Console.WriteLine("Texte: " + editeur.LireTexte());

            historique.Empiler(editeur.Sauvegarder());
            editeur.Ecrire(" !!!");
            Console.WriteLine("Texte: " + editeur.LireTexte());

            Console.WriteLine();
            Console.WriteLine("--- Annulations (undo) ---");

            while (historique.EstVide() == false)
            {
                Console.WriteLine();
                Console.WriteLine("Avant: [" + editeur.LireTexte() + "]");
                MementoEditeur precedent = historique.Depiler();
                editeur.Restaurer(precedent);
                Console.WriteLine("Aprés: [" + editeur.LireTexte() + "]");
            }
        }
    }
}