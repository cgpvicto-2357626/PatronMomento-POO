namespace MementoDemo
{
    /// <summary>
    /// Caretaker: garde les mementos dans une pile
    /// </summary>
    public class Historique
    {
        // Source: https://www.geeksforgeeks.org/c-sharp/stack-class-in-c-sharp/
        private Stack<MementoEditeur> pile = new Stack<MementoEditeur>();

        /// <summary>
        /// Ajoute un memento sur la pile.
        /// </summary>
        public void Empiler(MementoEditeur memento)
        {
            pile.Push(memento);
        }

        /// <summary>
        /// Retire et retourne le dernier memento (null si vide)
        /// </summary>
        public MementoEditeur Depiler()
        {
            if (pile.Count == 0)
            {
                return null;
            }
            return pile.Pop();
        }

        /// <summary>
        /// Retourne true si la pile est vide
        /// </summary>
        public bool EstVide()
        {
            if (pile.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}