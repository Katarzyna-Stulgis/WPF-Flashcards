using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.RenameWindows
{
    /// <summary>
    /// Logika interakcji dla klasy RenameFlashcardENG.xaml
    /// </summary>
    public partial class RenameFlashcardENG : Window
    {
        public RenameFlashcardENG()
        {
            InitializeComponent();
            FiszkaENG.Focus();

            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();
            int FiszkaID = model.getFiszkaID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            fiszka.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).odpowiedz;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();
            int FiszkaID = model.getFiszkaID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            string fiszkaENG = FiszkaENG.Text;

            if (!string.IsNullOrEmpty(fiszkaENG) && fiszkaENG.Length <= 46)
            {
                folder.categories.ElementAt(CategoryID).RenameOdpowiedz(FiszkaID, CategoryID, fiszkaENG);
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
