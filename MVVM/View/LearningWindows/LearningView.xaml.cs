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
        public static int FiszkaID = 1;
        public static int CurrentFlashcard = 0;

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

            FiszkaID = startFiszkaViewModel.getFiszkaID()+1;

            Category.Content = "Fiszki kategorii: " + folder.categories.ElementAt(CategoryID).name;

            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.First(x => x.id == FiszkaID).pytanie;
                int i = FiszkaID ;
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
                    FiszkaENG.Content = folder.categories.ElementAt(CategoryID).fiszki.First(x =>x.id == FiszkaID).odpowiedz;
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
            if (FiszkaID == 0)
            {
                FiszkaID = folder.categories.ElementAt(CategoryID).fiszki.Count;
            }


            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                FiszkaENG.Content = "";
                FiszkaPL.Content = "";
                FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.First(x =>x.id == FiszkaID).pytanie;

                int i = FiszkaID;
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
            if (folder.categories.ElementAt(CategoryID).fiszki.Count +1 == FiszkaID)
            {
                FiszkaID = 1;
            }

            if (folder.categories.ElementAt(CategoryID).fiszki.Count != 0)
            {
                FiszkaENG.Content = "";
                FiszkaPL.Content = "";
                FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.First(x => x.id == FiszkaID).pytanie;

                int i = FiszkaID;
                int all = folder.categories.ElementAt(CategoryID).fiszki.Count();
                number.Content = "Fiszka: " + i + " / " + all;
            }
        }

        private void ShuffleButton_Click(object sender, RoutedEventArgs e)
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            LearningFlashcardsViewModel startFiszkaViewModel = new LearningFlashcardsViewModel();
            int CategoryID = startFiszkaViewModel.getCategoryID();

            folder.categories.ElementAt(CategoryID).ShuffleFlashcards();
            
            FiszkaENG.Content = "";

            int flashcardId = folder.categories.ElementAt(CategoryID).fiszki.First().id;
            FiszkaID = flashcardId;
            FiszkaPL.Content = folder.categories.ElementAt(CategoryID).fiszki.First(x => x.id == flashcardId).pytanie;

            int i = FiszkaID ;
            int all = folder.categories.ElementAt(CategoryID).fiszki.Count();
            number.Content = "Fiszka: " + i + " / " + all;
        }
    }
}