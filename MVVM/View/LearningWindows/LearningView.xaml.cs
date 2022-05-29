using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.LearningViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Flashcards.MVVM.View.LearningWinodws
{
    /// <summary>
    /// Logika interakcji dla klasy LearningView.xaml
    /// </summary>
    public partial class LearningView : UserControl
    {
        public static int FiszkaID = 0;

        public LearningView()
        {
            InitializeComponent();
            SetLabel();
        }

        public void SetLabel()
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            LearningFlashcardsViewModel startFiszkaViewModel = new LearningFlashcardsViewModel();
            int CategoryID = startFiszkaViewModel.getCategoryID();

            FiszkaID = startFiszkaViewModel.getFiszkaID();

            Category.Content = "Fiszki kategorii: " + folder.categories.ElementAt(CategoryID).name;

            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie;
                int i = FiszkaID + 1;
                int all = folder.categories.ElementAt(CategoryID).fiszki.Count();
                number.Content = "Fiszka: " + i + " / " + all;
            }
            else
            {
                FiszkaPL.Content = "Nie posiadasz Fiszek";
                FiszkaENG.Content = "Przejdź do edycji i dodaj fiszki";
                number.Content = "brak fiszek";
            }
        }

        private void ShowAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            LearningFlashcardsViewModel startFiszkaViewModel = new LearningFlashcardsViewModel();
            int CategoryID = startFiszkaViewModel.getCategoryID();

            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                if (String.IsNullOrEmpty((string)FiszkaENG.Content))
                {
                    FiszkaENG.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).odpowiedz;
                    show.Content = "Ukryj Odpowiedź";
                }
                else
                {
                    FiszkaENG.Content = "";
                    show.Content = "Pokaż Odpowiedź";
                }
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            show.Content = "Pokaż Odpowiedź";
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            LearningFlashcardsViewModel startFiszkaViewModel = new LearningFlashcardsViewModel();
            int CategoryID = startFiszkaViewModel.getCategoryID();

            FiszkaID--;
            if (FiszkaID == -1)
            {
                FiszkaID = folder.categories.ElementAt(CategoryID).fiszki.Count - 1;
            }


            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                FiszkaENG.Content = "";
                FiszkaPL.Content = "";
                FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie;

                int i = FiszkaID + 1;
                int all = folder.categories.ElementAt(CategoryID).fiszki.Count();
                number.Content = "Fiszka: " + i + " / " + all;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            show.Content = "Pokaż Odpowiedź";
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            LearningFlashcardsViewModel startFiszkaViewModel = new LearningFlashcardsViewModel();
            int CategoryID = startFiszkaViewModel.getCategoryID();

            FiszkaID++;
            if (folder.categories.ElementAt(CategoryID).fiszki.Count == FiszkaID)
            {
                FiszkaID = 0;
            }


            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                FiszkaENG.Content = "";
                FiszkaPL.Content = "";
                FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(FiszkaID).pytanie;

                int i = FiszkaID + 1;
                int all = folder.categories.ElementAt(CategoryID).fiszki.Count();
                number.Content = "Fiszka: " + i + " / " + all;
            }

        }
    }
}
