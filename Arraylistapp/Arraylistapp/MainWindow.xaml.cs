using System;
using System.Collections;
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

namespace Arraylistapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayListName;
        public MainWindow()
        {
            InitializeComponent();
            arrayListName = new ArrayList();

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {   
            //Show Data
            foreach (string data in arrayListName)
            {
                MessageBox.Show("Name "+data);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            arrayListName.Add(txtName.Text);

        }

        private void button_Remove_Click(object sender, RoutedEventArgs e)
        {
            arrayListName.Remove(txtName.Text);
        }
    }
}
