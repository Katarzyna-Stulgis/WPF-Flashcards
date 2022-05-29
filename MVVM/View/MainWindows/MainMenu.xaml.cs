using Flashcards.MVVM.View.DialogWindows;
using System.Windows;
using System.Windows.Controls;

namespace Flashcards.MVVM.View.MainWindows
{
    /// <summary>
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow();
            exitWindow.ShowDialog();
        }
    }
}
