using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.DialogWindows
{
    /// <summary>
    /// Logika interakcji dla klasy RenameCategoryWindow.xaml
    /// </summary>
    public partial class RenameWindow : Window
    {
        public static string WindowType = "";
        int CategoryID;
        int FiszkaID;
        Folder folder;

        public RenameWindow(string windowType)
        {
            InitializeComponent();
            Input.Focus();
            WindowType = windowType;

            SelectWindow();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            switch (WindowType)
            {
                case "RenameCategoryWindow":
                    EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
                    int CategoryID = model.getCategoryID();

                    Folder folder = new Folder();
                    folder = folder.ShowFolder();

                    string categoryN = Input.Text;

                    if (!string.IsNullOrEmpty(categoryN) && categoryN.Length <= 46)
                    {
                        folder.RenameCategory(CategoryID, categoryN);
                        Close();
                    }
                    Error.Content = "Nazwa nie moze być pusta, ani dłuższa niż 46 znaków";
                    break;
                case "RenameFlashcardENG":
                    EditFlashcardOptionsViewModel model2 = new EditFlashcardOptionsViewModel();
                    CategoryID = model2.getCategoryID();
                    int FiszkaID = model2.getFiszkaID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    string fiszkaENG = Input.Text;

                    if (!string.IsNullOrEmpty(fiszkaENG) && fiszkaENG.Length <= 46)
                    {
                        folder.categories.ElementAt(CategoryID).RenameOdpowiedz(FiszkaID, CategoryID, fiszkaENG);
                        Close();
                    }

                    Error.Content = "Hasło nie moze być puste, ani dłuższe niż 46 znaków";
                    break;
                case "RenameFlashcardPL":
                    EditFlashcardOptionsViewModel model3 = new EditFlashcardOptionsViewModel();
                    CategoryID = model3.getCategoryID();
                    FiszkaID = model3.getFiszkaID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    string fiszkaPL = Input.Text;

                    if (!string.IsNullOrEmpty(fiszkaPL) && fiszkaPL.Length <= 46)
                    {
                        folder.categories.ElementAt(CategoryID).RenamePytanie(FiszkaID, CategoryID, fiszkaPL);
                        Close();
                    }
                    Error.Content = "Hasło nie moze być puste, ani dłuższe niż 46 znaków";
                    break;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SelectWindow()
        {
            switch (WindowType)
            {
                case "RenameCategoryWindow":
                    EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
                    int CategoryID = model.getCategoryID();

                    Folder folder = new Folder();
                    folder = folder.ShowFolder();

                    Title.Content = "Zmiana nazwy kategorii";
                    Question.Content = "Podaj nazwę nowej kategorii:";
                    Input.Text = folder.categories.ElementAt(CategoryID).name;
                    break;
                case "RenameFlashcardENG":
                    EditFlashcardOptionsViewModel model2 = new EditFlashcardOptionsViewModel();
                    CategoryID = model2.getCategoryID();
                    FiszkaID = model2.getFiszkaID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    Title.Content = "Zmiana angielskiego hasła";
                    Question.Content = "Podaj nowe angielskie hasło:";
                    Input.Text = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).odpowiedz;
                    break;
                case "RenameFlashcardPL":
                    EditFlashcardOptionsViewModel model3 = new EditFlashcardOptionsViewModel();
                    CategoryID = model3.getCategoryID();
                    FiszkaID = model3.getFiszkaID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    Title.Content = "Zmiana polskiego hasła";
                    Question.Content = "Podaj nowe polskie hasło:";
                    Input.Text = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie;
                    break;
            }
        }
    }
}
