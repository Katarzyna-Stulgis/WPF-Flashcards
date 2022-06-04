using Flashcards.MVVM.Model;
using Flashcards.MVVM.ViewModel.LearningViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Flashcards.MVVM.View.LearningWinodws
{
    /// <summary>
    /// Logika interakcji dla klasy LearningCategoriesView.xaml
    /// </summary>
    public partial class LearningCategoriesView : UserControl
    {
        List<Button> myButtons = new List<Button>();
        const int STEP = 2;
        int currentY = 0;

        public LearningCategoriesView()
        {
            InitializeComponent();
            MakeButton();
            AddButtonToStackPanel();
        }

        public void MakeButton()
        {
            Folder folder = new Folder();
            folder = folder.ShowFolder();

            int countCategories = folder.categories.Count();
            var converter = new BrushConverter();

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
                    Padding = new Thickness(30.0, 10.0, 30.0, 10.0),
                    Margin = new Thickness(15, 0, 15, 15),
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
                btnNew.SetBinding(Button.CommandProperty, new Binding("NavigateLearningFlashcardsCommand"));
                btnNew.Click += (sender, e) => { LearningCategoriesViewModel edit = new LearningCategoriesViewModel(categoryID); };
                myButtons.Add(btnNew);
            }
        }

        private void AddButtonToStackPanel()
        {
            foreach (var item in myButtons)
            {
                Canvas.SetBottom(item, STEP * currentY);
                currentY += 100;
                StackPanelButtons.Children.Add(item);
            }
        }
    }
}
