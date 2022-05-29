namespace Flashcards.MVVM.Model
{
    public class Flashcard
    {
        public int id;
        public string pytanie;
        public string odpowiedz;

        public Flashcard(int id, string pytanie, string odpowiedz)
        {
            this.id = id;
            this.pytanie = pytanie;
            this.odpowiedz = odpowiedz;
        }
    }
}
