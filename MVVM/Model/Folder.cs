using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Flashcards.MVVM.Model
{
    public class Folder
    {
        public LinkedList<Category> categories;

        public Folder()
        {
            categories = new LinkedList<Category>();
        }

        public Folder ShowFolder()
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);

            return folder;
        }

        public void AddCategory(string name)
        {
            Category c = new Category(name);

            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);

            folder.categories.AddLast(c);

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);
        }

        public void DeleteCategory(int index)
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);

            folder.categories.Remove(folder.categories.ElementAt(index));

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);
        }

        public void RenameCategory(int index, string name)
        {
            string f = File.ReadAllText("folder.json");
            Folder folder = JsonConvert.DeserializeObject<Folder>(f);


            folder.categories.ElementAt(index).name = name;

            string folderJson = JsonConvert.SerializeObject(folder);
            File.WriteAllText("folder.json", folderJson);
        }
    }
}
