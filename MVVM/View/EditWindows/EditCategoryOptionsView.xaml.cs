using Flashcards.MVVM.View.DeleteWindows;
using Flashcards.MVVM.View.RenameWindows;
using Flashcards.MVVM.ViewModel.EditViewModel;
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
            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();

            RenameCategoryWindow renameCategoryWindow = new RenameCategoryWindow();
            renameCategoryWindow.ShowDialog();

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();


            DeleteCategoryWindow deleteCategoryWindow = new DeleteCategoryWindow();
            deleteCategoryWindow.ShowDialog();

        }
    }
}
