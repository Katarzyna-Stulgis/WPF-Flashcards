using Flashcards.MVVM.Model;
using System.Windows;

namespace Flashcards.MVVM.View.DialogWindows.AddWindows
{
    /// <summary>
    /// Logika interakcji dla klasy AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : Window
    {
        public bool ButtonWasClicked = false;

        public AddCategoryWindow()
        {
            InitializeComponent();
            CategoryName.Focus();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            string categoryName = CategoryName.Text;
            if (!string.IsNullOrEmpty(categoryName) && categoryName.Length <= 46)
            {
                folder.AddCategory(categoryName);
                ButtonWasClicked = true;
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
