using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.DeleteWindows
{
    /// <summary>
    /// Logika interakcji dla klasy DeleteCategoryWindow.xaml
    /// </summary>
    public partial class DeleteCategoryWindow : Window
    {
        public static bool wasClicked = false;

        public DeleteCategoryWindow()
        {
            InitializeComponent();
            CategoryName.Focus();

            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            CategoryName.Content = folder.categories.ElementAt(CategoryID).name;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            folder.DeleteCategory(CategoryID);
            wasClicked = true;
            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public bool WasClicked()
        {
            return wasClicked;
        }
    }
}
