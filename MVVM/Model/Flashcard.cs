namespace Flashcards.MVVM.Model
{
    public class Flashcard
    {
        public string pytanie;
        public string odpowiedz;

        public Flashcard(string pytanie, string odpowiedz)
        {
            this.pytanie = pytanie;
            this.odpowiedz = odpowiedz;
        }
    }
}
