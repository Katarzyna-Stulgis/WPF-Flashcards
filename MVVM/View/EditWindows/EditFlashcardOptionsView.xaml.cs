using Flashcards.MVVM.View.DialogWindows;
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
            RenameWindow renamePLFiszkaWindow = new RenameWindow("RenameFlashcardPL");
            renamePLFiszkaWindow.ShowDialog();
        }

        private void EditENGFiszkaButton_Click(object sender, RoutedEventArgs e)
        {
            RenameWindow renameANGFiszkaWindow = new RenameWindow("RenameFlashcardENG");
            renameANGFiszkaWindow.ShowDialog();
        }

        private void DeleteFiszkaButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteWindow deleteWindow = new DeleteWindow("DeleteFlashcardWindow");
            deleteWindow.ShowDialog();
        }
    }
}
