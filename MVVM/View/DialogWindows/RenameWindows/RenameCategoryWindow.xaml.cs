using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.RenameWindows
{
    /// <summary>
    /// Logika interakcji dla klasy RenameCategoryWindow.xaml
    /// </summary>
    public partial class RenameCategoryWindow : Window
    {
        public RenameCategoryWindow()
        {
            InitializeComponent();
            CategoryTextBox.Focus();
            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            CategoryTextBox.Text = folder.categories.ElementAt(CategoryID).name;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            string categoryN = CategoryTextBox.Text;

            if (!string.IsNullOrEmpty(categoryN) && categoryN.Length <= 46)
            {
                folder.RenameCategory(CategoryID, categoryN);
                Close();
            }
            error.Content = "Nazwa nie moze być pusta, ani dłuższa niż 46 znaków";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
