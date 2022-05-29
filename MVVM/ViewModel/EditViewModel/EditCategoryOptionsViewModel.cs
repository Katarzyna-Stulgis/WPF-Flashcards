using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.EditViewModel
{
    class EditCategoryOptionsViewModel : ObservableObject
    {
        public ICommand NavigateEditCommand { get; }

        public ICommand NavigateEditFiszkaCommand { get; }

        public static int categoryID;

        public EditCategoryOptionsViewModel() { }

        public EditCategoryOptionsViewModel(NavigationStore navigationStore)
        {
            NavigateEditCommand = new NavigateCommand<EditCategoryViewModel>(navigationStore, () => new EditCategoryViewModel(navigationStore));
        }

        public EditCategoryOptionsViewModel(NavigationStore navigationStore, int CategoryID)
        {
            categoryID = CategoryID;

            NavigateEditCommand = new NavigateCommand<EditCategoryViewModel>(navigationStore, () => new EditCategoryViewModel(navigationStore));

            NavigateEditFiszkaCommand = new NavigateCommand<EditFlashcardViewModel>(navigationStore, () => new EditFlashcardViewModel(navigationStore, CategoryID));
        }

        public int getCategoryID()
        {
            return categoryID;
        }
    }
}
