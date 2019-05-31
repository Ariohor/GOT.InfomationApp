using GOT.Models;
using System.Collections;
using System.Windows;

namespace GOT.InformationApp
{
    /// <summary>
    /// Interaction logic for CharacterInfoWindow.xaml
    /// </summary>
    public partial class CharacterInfoWindow : Window
    {

        public CharacterInfoWindow()
        {
            InitializeComponent();
        }

        public CharacterInfoWindow(IList addedItems)
        {
            InitializeComponent();
            DataContext = addedItems[0];
            titlesListView.ItemsSource = (addedItems[0] as Character).Titles;
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            var res = titlesListView.ItemsSource;
            this.Close();
        }
    }
}
