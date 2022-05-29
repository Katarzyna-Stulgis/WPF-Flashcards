using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.EditViewModel
{
    class EditFlashcardViewModel : ObservableObject
    {
        public ICommand NavigateEditCategoryViewCommand { get; }

        public ICommand NavigateEditFlashcardOptionsCommand { get; }

        public static int fiszkaID;

        public static int categoryID;

        public EditFlashcardViewModel()
        {
        }

        public EditFlashcardViewModel(NavigationStore navigationStore, int CategoryID)
        {
            categoryID = CategoryID;

            NavigateEditCategoryViewCommand = new NavigateCommand<EditCategoryViewModel>(navigationStore, () => new EditCategoryViewModel(navigationStore));

            NavigateEditFlashcardOptionsCommand = new NavigateCommand<EditFlashcardOptionsViewModel>(navigationStore, () => new EditFlashcardOptionsViewModel(navigationStore, CategoryID, fiszkaID));
        }

        public int getCategoryID()
        {
            return categoryID;
        }

        public EditFlashcardViewModel(int fiszka)
        {
            fiszkaID = fiszka;
        }
    }
}