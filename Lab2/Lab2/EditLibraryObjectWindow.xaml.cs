using Lab2.Models;
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
using System.Windows.Shapes;

namespace Lab2
{
    /// <summary>
    /// Логика взаимодействия для EditLibraryObjectWindow.xaml
    /// </summary>
    public partial class EditLibraryObjectWindow : Window
    {
        public EditLibraryObjectWindow(object libraryObject)
        {
            InitializeComponent();
            GenerateMarkup(libraryObject);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
    
        }

        private void GenerateMarkup<T>(T libraryObject)
        {
            var fieldsSet = libraryObject.GetType().GetFields();
            var window = this;
            foreach (var field in fieldsSet)
            {
                var item = field.GetValue(null);
                switch (item)
                {
                    case string s:
                    case int i:
                        TextBox textbox = new TextBox();
                        textbox.Width = 200;
                        textbox.Height = 200;
                        textbox.Text = "привет";
                        this.MyGrid.Children.Add(textbox);
                        // общий блок для создания текстбоксов
                        return;

                    case Enum e:
                        ComboBox comboBox = new ComboBox();
                        comboBox.Width = 200;
                        comboBox.Height = 200;
                        this.MyGrid.Children.Add(comboBox);
                        //блок для выпадающих списков
                        return;

                    case ICollection<T> c:

                        //блок для коллекций. просто игнорируем. Листы будут редактироваться в самих элементах, которые в этом листе
                        return;

                    default:
                        GenerateMarkup(item);
                        //Это для вложенных объектов.
                        //если это вложенный объект - то его мы снова прокидываем в этот же метод рекурсией
                        return;
                }
            }
        }

    }
}
