using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.RenameWindows
{
    /// <summary>
    /// Logika interakcji dla klasy RenameFlashcardPL.xaml
    /// </summary>
    public partial class RenameFlashcardPL : Window
    {
        public RenameFlashcardPL()
        {
            InitializeComponent();

            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();
            int FiszkaID = model.getFiszkaID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            fiszka.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();
            int FiszkaID = model.getFiszkaID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            string fiszkaPL = FiszkaPL.Text;

            if (!string.IsNullOrEmpty(fiszkaPL) && fiszkaPL.Length <= 46)
            {
                folder.categories.ElementAt(CategoryID).RenamePytanie(FiszkaID, CategoryID, fiszkaPL);
                Close();
            }
            error.Content = "Hasło nie moze być puste, ani dłuższe niż 46 znaków";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
