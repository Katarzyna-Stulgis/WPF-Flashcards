using Flashcards.MVVM.Model;
using Flashcards.MVVM.View.DeleteWindows;
using Flashcards.MVVM.View.RenameWindows;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Flashcards.MVVM.View.EditWindows
{
    /// <summary>
    /// Logika interakcji dla klasy EditFlashcardOptionsView.xaml
    /// </summary>
    public partial class EditFlashcardOptionsView : UserControl
    {
        public EditFlashcardOptionsView()
        {
            InitializeComponent();
        }
        private void EditPLFiszkaButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();

            RenameFlashcardPL renamePLFiszkaWindow = new RenameFlashcardPL();
            renamePLFiszkaWindow.ShowDialog();

        }

        private void EditENGFiszkaButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            RenameFlashcardENG renameANGFiszkaWindow = new RenameFlashcardENG();
            renameANGFiszkaWindow.ShowDialog();

        }

        private void DeleteFiszkaButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardOptionsViewModel model = new EditFlashcardOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            DeleteFlashcardWindow deleteFiszkaWindow = new DeleteFlashcardWindow();
            deleteFiszkaWindow.ShowDialog();
        }
    }
}
