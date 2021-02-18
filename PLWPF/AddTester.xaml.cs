using BL_3300;
using DAL;
using BE;
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
    /// Interaction logic for AddTester.xaml
    /// </summary>
    public partial class AddTester : Window
    {
        public AddTester()
        {
            InitializeComponent();
            ComboBoxItem comboBox1 = new ComboBoxItem();


            comboBox1.Content = "private_auto ";
            comboBox1.Items.Add(newItem);
            comboBox1.Content = "car_TwoWheels ";
            comboBox1.Items.Add(newItem)
                comboBox1.Content = "Medium_truck ";
            comboBox1.Items.Add(newItem)
                comboBox1.Content = "Heavy_truck ";
            comboBox1.Items.Add(newItem)


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BL.BL_imp.addTester(Tester);
                MessageBox.Show("the tester \"" + Tester.id + "\" added to the list", "");
                var Window = new BE.Tester();
                this.gridAddBranch.DataContext = Window;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
