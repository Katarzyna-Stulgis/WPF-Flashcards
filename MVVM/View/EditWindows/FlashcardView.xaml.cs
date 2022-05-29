using Flashcards.MVVM.Model;
using Flashcards.MVVM.View.DialogWindows.AddWindows;
using Flashcards.MVVM.ViewModel.EditViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Flashcards.MVVM.View.EditWindows
{
    /// <summary>
    /// Logika interakcji dla klasy FlashcardView.xaml
    /// </summary>
    public partial class FlashcardView : UserControl
    {
        List<Button> myButtons = new List<Button>();

        public FlashcardView()
        {
            InitializeComponent();
            MakeButtons();
            AddButtonToStackPanel();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            EditFlashcardViewModel model = new EditFlashcardViewModel();

            AddFlashcardWindow addFiszkaWindow = new AddFlashcardWindow();
            addFiszkaWindow.ShowDialog();

            if (addFiszkaWindow.ButtonWasClicked == true)
            {
                AddNewButon();
            }
        }

        public void MakeButtons()
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            EditFlashcardViewModel model = new EditFlashcardViewModel();
            int CategoryID = model.getCategoryID();

            int countFiszki = folder.categories.ElementAt(CategoryID).fiszki.Count();
            var converter = new System.Windows.Media.BrushConverter();

            var brushBackground = (Brush)converter.ConvertFromString("#161426");
            var brushForeground = (Brush)converter.ConvertFromString("#ffffff");

            for (int i = 0; i < countFiszki; i++)
            {
                string fiszka = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(i).pytanie + " - " + folder.categories.ElementAt(CategoryID).fiszki.ElementAt(i).odpowiedz;
                Button btnNew = new Button()
                {
                    Background = brushBackground,
                    Foreground = brushForeground,
                    Content = fiszka,
                    FontSize = 20,
                    Width = 975,
                    Height = 50,
                    Margin = new Thickness(0, 0, 0, 15),
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    Resources = {
                        {
                            typeof(Border), new Style{
                                TargetType = typeof(Border),
                                Setters = {
                                    new Setter {Property = Border.CornerRadiusProperty, Value = new CornerRadius(8)},
                                }
                            }
                        }
                    }
                };
                int fiszkaID = i;
                btnNew.SetBinding(Button.CommandProperty, new Binding("NavigateEditFlashcardOptionsCommand"));
                btnNew.Click += (sender, e) => { EditFlashcardViewModel edit = new EditFlashcardViewModel(fiszkaID); };
                myButtons.Add(btnNew);
            }
        }

        private void AddNewButon()
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            EditFlashcardViewModel model = new EditFlashcardViewModel();
            int CategoryID = model.getCategoryID();

            int countFiszki = folder.categories.ElementAt(CategoryID).fiszki.Count();
            var converter = new System.Windows.Media.BrushConverter();

            var brushBackground = (Brush)converter.ConvertFromString("#161426");
            var brushForeground = (Brush)converter.ConvertFromString("#ffffff");


            string fiszka = folder.categories.ElementAt(CategoryID).fiszki.ElementAt(countFiszki - 1).pytanie + " - " + folder.categories.ElementAt(CategoryID).fiszki.ElementAt(countFiszki - 1).odpowiedz;
            Button btnNew = new Button()
            {
                Background = brushBackground,
                Foreground = brushForeground,
                Content = fiszka,
                FontSize = 20,
                Width = 975,
                Height = 50,
                Margin = new Thickness(0, 0, 0, 15),
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                Resources = {
                        {
                            typeof(Border), new Style{
                                TargetType = typeof(Border),
                                Setters = {
                                    new Setter {Property = Border.CornerRadiusProperty, Value = new CornerRadius(8)},
                                }
                            }
                        }
                    }
            };
            int fiszkaID = countFiszki - 1;
            btnNew.SetBinding(Button.CommandProperty, new Binding("NavigateEditFlashcardOptionsCommand"));
            btnNew.Click += (sender, e) => { EditFlashcardViewModel edit = new EditFlashcardViewModel(fiszkaID); };
            myButtons.Add(btnNew);
            StackPanelButtonsFiszka.Children.Add(btnNew);


        }
        private void AddButtonToStackPanel()
        {
            foreach (var item in myButtons)
            {
                StackPanelButtonsFiszka.Children.Add(item);
            }
        }
    }
}
