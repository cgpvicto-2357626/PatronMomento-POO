namespace MementoDemo
{
    /// <summary>
    /// Originator: l'objet dont on sauvegarde l'état
    /// </summary>
    public class Editeur
    {
        private string texte = "";

        /// <summary>
        /// Ajoute du texte à la fin du texte actuel
        /// </summary>
        public void Ecrire(string ajout)
        {
            texte = texte + ajout;
        }

        /// <summary>
        /// Retourne le texte actuel
        /// </summary>
        public string LireTexte()
        {
            return texte;
        }

        /// <summary>
        /// Crée un memento avec l'état actuel
        /// </summary>
        public MementoEditeur Sauvegarder()
        {
            return new MementoEditeur(texte);
        }

        /// <summary>
        /// Remet le texte à l'état du memento
        /// </summary>
        public void Restaurer(MementoEditeur memento)
        {
            if (memento == null)
            {
                return;
            }
            texte = memento.Texte;
        }
    }
}