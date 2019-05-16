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

namespace Lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Core core;
        public MainWindow()
        {
            core = new Core();
            InitializeComponent();
            DesplayObjectListView.ItemsSource = core.LibraryObjectAnnotations;
            ObjectSelector.ItemsSource = core.LibraryObejects;

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            String s = ObjectSelector.Text;
            Type t = Type.GetType(s);
            var c = Activator.CreateInstance(t);
            EditLibraryObjectWindow editLibraryObjectWindow = new EditLibraryObjectWindow(c);
            editLibraryObjectWindow.ShowDialog();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() { return Text; }

    }
}
