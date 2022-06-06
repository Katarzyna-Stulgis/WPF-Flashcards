using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Controls;

namespace Flashcards.MVVM.Model
{
    public class Category
    {
        public string name { get; set; }

        public List<Flashcard> fiszki { get; set; }

        public Category(string name)
        {
            this.name = name;
            fiszki = new List<Flashcard>();
        }

        public void AddFiszka(int index, string pytanie, string odpowiedz)
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);

            Flashcard fiszka = new Flashcard(folder.categories.ElementAt(index).fiszki.Count + 1, pytanie, odpowiedz);



            folder.categories.ElementAt(index).fiszki.Add(fiszka);

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

        public void ShuffleFlashcards()
        {
            var rnd = new Random();
            var randomized = fiszki.OrderBy(item => rnd.Next()).ToList();
            fiszki = randomized;
            var x = fiszki;
        }
    }
}
