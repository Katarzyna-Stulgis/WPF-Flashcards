using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;

namespace Flashcards.MVVM.View.DialogWindows
{
    /// <summary>
    /// Logika interakcji dla klasy DeleteCategoryWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public static string WindowType = "";
        int CategoryID;
        Folder folder;

        public DeleteWindow(string windowType)
        {
            InitializeComponent();
            DeletedName.Focus();

            WindowType = windowType;

            SelectWindow();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            switch (WindowType)
            {
                case "DeleteCategoryWindow":
                    EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
                    CategoryID = model.getCategoryID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    folder.DeleteCategory(CategoryID);
                    break;
                case "DeleteFlashcardWindow":
                    EditFlashcardOptionsViewModel model2 = new EditFlashcardOptionsViewModel();
                    CategoryID = model2.getCategoryID();
                    int FiszkaID = model2.getFiszkaID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    folder.categories.ElementAt(CategoryID).DeleteFiszka(FiszkaID, CategoryID);
                    break;
            }

            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SelectWindow()
        {
            switch (WindowType)
            {
                case "DeleteCategoryWindow":
                    EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
                    int CategoryID = model.getCategoryID();

                    Folder folder = new Folder();
                    folder = folder.ShowFolder();

                    Title.Content = "Usuwanie kategorii";
                    Question.Content = "Czy na pewno chcesz usunąć kategorię o nazwie:";
                    DeletedName.Content = folder.categories.ElementAt(CategoryID).name;
                    break;

                case "DeleteFlashcardWindow":
                    EditFlashcardOptionsViewModel model2 = new EditFlashcardOptionsViewModel();
                    CategoryID = model2.getCategoryID();
                    int FiszkaID = model2.getFiszkaID();

                    folder = new Folder();
                    folder = folder.ShowFolder();

                    Title.Content = "Usuwanie fiszki";
                    Question.Content = "Czy na pewno chcesz usunąć fiszkę:";
                    DeletedName.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie + " - " + folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).odpowiedz;
                    break;
            }
        }
    }
}
