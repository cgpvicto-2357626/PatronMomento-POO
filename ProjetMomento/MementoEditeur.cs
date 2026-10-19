namespace MementoDemo
{
    /// <summary>
    /// Memento: capsule qui contient l'état sauvegardé
    /// </summary>
    public class MementoEditeur
    {
        /// <summary>
        /// Le texte sauvegardé (lecture seule)
        /// </summary>
        public string Texte { get; private set; }

        /// <summary>
        /// Crée un memento avec le texte donné
        /// </summary>
        public MementoEditeur(string texte)
        {
            Texte = texte;
        }
    }
}