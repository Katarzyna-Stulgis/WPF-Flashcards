using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.EditViewModel
{
    class EditFlashcardOptionsViewModel : ObservableObject
    {
        public ICommand NavigateEditFlashcardCommand { get; }

        public static int fiszkaID;

        public static int categoryID;

        public EditFlashcardOptionsViewModel() { }

        public EditFlashcardOptionsViewModel(NavigationStore navigationStore, int CategoryID, int FiszkaID)
        {
            categoryID = CategoryID;

            fiszkaID = FiszkaID;

            NavigateEditFlashcardCommand = new NavigateCommand<EditFlashcardViewModel>(navigationStore, () => new EditFlashcardViewModel(navigationStore, CategoryID));
        }

        public int getCategoryID()
        {
            return categoryID;
        }

        public int getFiszkaID()
        {
            return fiszkaID;
        }

        public EditFlashcardOptionsViewModel(int fiszka)
        {
            fiszkaID = fiszka;
        }
    }
}
