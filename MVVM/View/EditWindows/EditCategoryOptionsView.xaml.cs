using Flashcards.MVVM.Model;
using Flashcards.MVVM.View.DialogWindows;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            EditCategoryOptionsViewModel model = new EditCategoryOptionsViewModel();
            int CategoryID = model.getCategoryID();

            Folder folder = new Folder();
            folder = folder.ShowFolder();
            var flashcards = folder.categories.ElementAt(CategoryID).fiszki;

            FlowDocument fd = new FlowDocument();
            fd.Blocks.Add(new Paragraph(new Bold(new Run(folder.categories.ElementAt(CategoryID).name.ToString()))));
            fd.Blocks.Add(new Paragraph());
            foreach (var item in flashcards)
            {
                string flashcard = "\t" + item.pytanie + " - " + item.odpowiedz;
                fd.Blocks.Add(new Paragraph(new Run(flashcard.ToString())));
            }

            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() != true) return;

            fd.PageHeight = pd.PrintableAreaHeight;
            fd.PageWidth = pd.PrintableAreaWidth;

            IDocumentPaginatorSource idocument = fd;

            pd.PrintDocument(idocument.DocumentPaginator, "Printing Flow Document...");
        }
    }
}
