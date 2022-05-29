using Flashcards.Commands;
using Flashcards.Core;
using Flashcards.MVVM.ViewModel.MainViewModel;
using Flashcards.Stores;
using System.Windows.Input;

namespace Flashcards.MVVM.ViewModel.EditViewModel
{
    class EditCategoryViewModel : ObservableObject
    {
        public ICommand NavigateMainMenuCommand { get; }

        public ICommand NavigateEditCategoryOptionsCommand { get; }

        public static int categoryID;

        public EditCategoryViewModel(NavigationStore navigationStore)
        {
            NavigateMainMenuCommand = new NavigateCommand<MainMenuViewModel>(navigationStore, () => new MainMenuViewModel(navigationStore));

            NavigateEditCategoryOptionsCommand = new NavigateCommand<EditCategoryOptionsViewModel>(navigationStore, () => new EditCategoryOptionsViewModel(navigationStore, categoryID));
        }

        public EditCategoryViewModel(int category)
        {
            categoryID = category;
        }
    }
}