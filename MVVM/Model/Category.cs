using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Flashcards.MVVM.Model
{
    public class Category
    {
        public string name { get; set; }

        public LinkedList<Flashcard> fiszki;

        public Category(string name)
        {
            this.name = name;
            fiszki = new LinkedList<Flashcard>();
        }

        public void AddFiszka(int index, string pytanie, string odpowiedz)
        {
            Flashcard fiszka = new Flashcard(pytanie, odpowiedz);

            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);

            folder.categories.ElementAt(index).fiszki.AddLast(fiszka);

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);
        }

        public void RenamePytanie(int indexFiszka, int indexCategory, string pytanie)
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);


            folder.categories.ElementAt(indexCategory).fiszki.ElementAt(indexFiszka).pytanie = pytanie;

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);

        }
        public void RenameOdpowiedz(int indexFiszka, int indexCategory, string odpowiedz)
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);


            folder.categories.ElementAt(indexCategory).fiszki.ElementAt(indexFiszka).odpowiedz = odpowiedz;

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);

        }

        public void DeleteFiszka(int indexFiszka, int indexCategory)
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);

            folder.categories.ElementAt(indexCategory).fiszki.Remove(folder.categories.ElementAt(indexCategory).fiszki.ElementAt(indexFiszka));

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);
        }
    }
}
