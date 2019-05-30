using GOT.Services;
using GOT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GOT.InformationApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dataHandler = new DataHandler();
            var result = dataHandler.GetCharacters();

            caracterListBox.ItemsSource = result;

        }

        private void SearchTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var dataHandler = new DataHandler();
                caracterListBox.ItemsSource = dataHandler.SearchCaracters(caracterListBox.ItemsSource as IList<Character>,searchTextBox.Text);
            }
        }

        private void CaracterListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var res = e.AddedItems;
        }
    }
}
