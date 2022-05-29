using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.LearningViewModel
{
    class LearningFlashcardsViewModel : ObservableObject
    {
        public ICommand NavigateLearningCategoriesCommand { get; }

        public static int categoryID;

        public static int fiszkaID;

        public LearningFlashcardsViewModel() { }

        public LearningFlashcardsViewModel(NavigationStore navigationStore, int CategoryID, int FiszkaID)
        {
            categoryID = CategoryID;

            fiszkaID = FiszkaID;

            NavigateLearningCategoriesCommand = new NavigateCommand<LearningCategoriesViewModel>(navigationStore, () => new LearningCategoriesViewModel(navigationStore));
        }

        public int getCategoryID()
        {
            return categoryID;
        }

        public int getFiszkaID()
        {
            return fiszkaID;
        }
    }
}
