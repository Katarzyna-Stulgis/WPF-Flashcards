using Flashcards.MVVM.ViewModel.EditViewModel;
using Flashcards.MVVM.Model;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.DialogWindows.AddWindows
{
    /// <summary>
    /// Logika interakcji dla klasy AddFlashcardWindow.xaml
    /// </summary>
    public partial class AddFlashcardWindow : Window
    {
        public bool ButtonWasClicked = false;

        public AddFlashcardWindow()
        {
            InitializeComponent();
            FiszkaPL.Focus();

            EditFlashcardViewModel model = new EditFlashcardViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            title.Content = "Nowa fiszka kategorii: " + folder.categories.ElementAt(CategoryID).name;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            EditFlashcardViewModel model = new EditFlashcardViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();

            string plFiszka = FiszkaPL.Text;
            string engFiszka = FiszkaENG.Text;

            if (!string.IsNullOrEmpty(plFiszka) && plFiszka.Length <= 46 && !string.IsNullOrEmpty(engFiszka) && engFiszka.Length <= 46)
            {
                folder.categories.ElementAt(CategoryID).AddFiszka(CategoryID, plFiszka, engFiszka);
                ButtonWasClicked = true;
                Close();
            }
            else if (string.IsNullOrEmpty(plFiszka) || plFiszka.Length > 46)
            {

                error1.Content = "Hasło nie moze być puste, ani dłuższe niż 46 znaków";
            }
            else if (string.IsNullOrEmpty(engFiszka) || engFiszka.Length > 46)
            {

                error2.Content = "Hasło nie moze być puste, ani dłuższe niż 46 znaków";
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
