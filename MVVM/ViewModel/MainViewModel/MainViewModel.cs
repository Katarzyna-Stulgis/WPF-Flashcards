using Flashcards.Core;
using Flashcards.Stores;

namespace Flashcards.MVVM.ViewModel.MainViewModel
{
    class MainViewModel : ObservableObject
    {
        private readonly NavigationStore _navigatonStore;

        public ObservableObject CurrentViewModel => _navigatonStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigatonStore = navigationStore;
            _navigatonStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}