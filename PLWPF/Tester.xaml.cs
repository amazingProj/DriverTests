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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Tester1.xaml
    /// </summary>
    public partial class Tester1 : Window
    {
        public Tester1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddTester();
            window.ShowDialog();

        }

        private void Delete_button1_Click(object sender, RoutedEventArgs e)
        {
            var window = new DeleteTester();
            window.ShowDialog();
        }

        private void Update_button2_Click(object sender, RoutedEventArgs e)
        {
            var window = new UpdateTester();
            window.ShowDialog();
        }
    }
}
