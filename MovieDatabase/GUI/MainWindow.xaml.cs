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
using Core;

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();







        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var prov = new MongoProvider<Film>("localhost", 27017);
            prov.Intialize();

            Film f = new Film() { Name = "XY", Storyline = "Nichts Geschieht" };
            f.Genres.Add(Genre.Action);
            f.Genres.Add(Genre.Fantasy);

            prov.SaveElement(f);


            
            var x = prov.GetElements();

            var stringsss = prov.ToString();
            
        }
    }
}
