using GOT.Services;
using GOT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GOT.DataAccess;

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

            if (result == null)
            {
                using(var context =new GOTContext())
                {
                    result = context.Characters.ToList();
                }
            }

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
