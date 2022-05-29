using Flashcards.MVVM.Model;
using Flashcards.MVVM.View.DialogWindows.AddWindows;
using Flashcards.MVVM.ViewModel.EditViewModel;
using Flashcards.Stores;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Flashcards.MVVM.View.EditWindows
{
    /// <summary>
    /// Logika interakcji dla klasy CategoryView.xaml
    /// </summary>
    public partial class CategoryView : UserControl
    {
        List<Button> myButtons = new List<Button>();

        public CategoryView()
        {
            InitializeComponent();
            MakeButtons();
            AddButtonToStackPanel();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            AddCategoryWindow addCategoryWindow = new AddCategoryWindow();
            addCategoryWindow.ShowDialog();

            if (addCategoryWindow.ButtonWasClicked == true)
            {
                AddNewButon();
            }
        }

        public void MakeButtons()
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            int countCategories = folder.categories.Count();
            var converter = new System.Windows.Media.BrushConverter();

            var brushBackground = (Brush)converter.ConvertFromString("#161426");
            var brushForeground = (Brush)converter.ConvertFromString("#ffffff");

            for (int i = 0; i < countCategories; i++)
            {
                Button btnNew = new Button()
                {
                    Background = brushBackground,
                    Foreground = brushForeground,
                    Content = folder.categories.ElementAt(i).name,
                    FontSize = 20,
                    Width = 500,
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
                int categoryID = i;
                btnNew.SetBinding(Button.CommandProperty, new Binding("NavigateEditCategoryOptionsCommand"));
                btnNew.Click += (sender, e) => { EditCategoryViewModel edit = new EditCategoryViewModel(categoryID); };
                myButtons.Add(btnNew);
            }
        }

        private void AddButtonToStackPanel()
        {
            foreach (var item in myButtons)
            {
                StackPanelButtons.Children.Add(item);
            }
        }

        private void AddNewButon()
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            int countCategories = folder.categories.Count();
            var converter = new System.Windows.Media.BrushConverter();

            var brushBackground = (Brush)converter.ConvertFromString("#161426");
            var brushForeground = (Brush)converter.ConvertFromString("#ffffff");

            NavigationStore navigationStore = new NavigationStore();
            EditCategoryViewModel editViewModel = new EditCategoryViewModel(navigationStore);

            Button btnNew = new Button()
            {
                Background = brushBackground,
                Foreground = brushForeground,
                Content = folder.categories.ElementAt(countCategories - 1).name,
                FontSize = 20,
                Width = 500,
                Height = 50,
                Margin = new Thickness(0, 0, 0, 15),
                Command = editViewModel.NavigateEditCategoryOptionsCommand,
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
            int categoryID = myButtons.Count;
            btnNew.SetBinding(Button.CommandProperty, new Binding("NavigateEditCategoryOptionsCommand"));
            btnNew.Click += (sender, e) => { EditCategoryViewModel edit = new EditCategoryViewModel(categoryID); };
            myButtons.Add(btnNew);

            StackPanelButtons.Children.Add(btnNew);
        }
    }
}