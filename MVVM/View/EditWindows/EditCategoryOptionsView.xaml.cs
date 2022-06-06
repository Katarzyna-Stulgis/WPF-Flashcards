using Flashcards.MVVM.View.DialogWindows;
using System.Windows;
using System.Windows.Controls;

namespace Flashcards.MVVM.View.EditWindows
{
    /// <summary>
    /// Logika interakcji dla klasy EditCategoryOptionsView.xaml
    /// </summary>
    public partial class EditCategoryOptionsView : UserControl
    {
        public EditCategoryOptionsView()
        {
            InitializeComponent();
        }

        private void RenameButton_Click(object sender, RoutedEventArgs e)
        {
            RenameWindow renameCategoryWindow = new RenameWindow("RenameCategoryWindow");
            renameCategoryWindow.ShowDialog();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteWindow deleteCategoryWindow = new DeleteWindow("DeleteCategoryWindow");
            deleteCategoryWindow.ShowDialog();
        }
    }
}
