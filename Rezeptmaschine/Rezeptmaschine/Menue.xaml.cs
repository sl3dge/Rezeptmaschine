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

namespace Rezeptmaschine
{
    /// <summary>
    /// Interaktionslogik für Menue.xaml
    /// </summary>
    public partial class Menue : Window
    {
        public Menue()
        {
            InitializeComponent();
        }

        void fileExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Close this window
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window rezept = new neuesRezept();
            rezept.Owner = this;
            rezept.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window einkauf = new Einkaufsliste();
            einkauf.Owner = this;
            einkauf.Show();
        }
    }
}
