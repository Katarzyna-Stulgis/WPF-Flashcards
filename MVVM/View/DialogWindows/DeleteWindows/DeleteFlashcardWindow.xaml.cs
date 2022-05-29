using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.DeleteWindows
{
    /// <summary>
    /// Logika interakcji dla klasy DeleteFlashcardWindow.xaml
    /// </summary>
    public partial class DeleteFlashcardWindow : Window
    {
        public DeleteFlashcardWindow()
        {
            InitializeComponent();

            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();
            int FiszkaID = model.getFiszkaID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            Fiszka.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie + " - " + folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).odpowiedz;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();
            int FiszkaID = model.getFiszkaID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            folder.categories.ElementAt(CategoryID).DeleteFiszka(FiszkaID, CategoryID);

            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
