﻿using Flashcards.Core;
using System;


namespace Flashcards.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;
        private ObservableObject _currentViewModel;

        public ObservableObject CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
