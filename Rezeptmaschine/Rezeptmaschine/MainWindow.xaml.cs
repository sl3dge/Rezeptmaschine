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

namespace Rezeptmaschine
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
        void fileExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Close this window
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window Menue = new Menue();
            Menue.Owner = this;
            Menue.Show();
        }
    }
}
