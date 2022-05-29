using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.MVVM.ViewModel.MainViewModel;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.LearningViewModel
{
    class LearningCategoriesViewModel : ObservableObject
    {
        public ICommand NavigateMainMenuCommand { get; }

        public ICommand NavigateLearningFlashcardsCommand { get; }

        public static int categoryID;

        public static int fiszkaId = 0;

        public LearningCategoriesViewModel(NavigationStore navigationStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore));

            NavigateLearningFlashcardsCommand = new NavigateCommand<LearningFlashcardsViewModel>(navigationStore, () => new LearningFlashcardsViewModel(navigationStore, categoryID, fiszkaId));
        }

        public LearningCategoriesViewModel(int category)
        {
            categoryID = category;
        }
    }
}
