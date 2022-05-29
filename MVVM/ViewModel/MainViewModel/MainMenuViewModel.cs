using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.MVVM.ViewModel.EditViewModel;
using Flashcards.MVVM.ViewModel.LearningViewModel;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.MainViewModel
{
    class MainMenuViewModel : ObservableObject
    {
        public ICommand NavigateLearningCommand { get; }

        public ICommand NavigateEditCommand { get; }

        public MainMenuViewModel(NavigationStore navigationStore)
        {
            NavigateLearningCommand = new NavigateCommand<LearningCategoriesViewModel>(navigationStore, () => new LearningCategoriesViewModel(navigationStore));

            NavigateEditCommand = new NavigateCommand<EditCategoryViewModel>(navigationStore, () => new EditCategoryViewModel(navigationStore));
        }
    }
}
