using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calcurator_Event
{
    /// <summary>
    /// Interaction logic for MainWindow_Event.xaml
    /// </summary>
    public partial class MainWindow_Event : Window
    {
        private int TestNumber = 0;                         

        public MainWindow_Event()
        {
            InitializeComponent();
            
           // txtTitle.Text = "Welcome to MVVM Light";
           // lblCount.Content = "0";
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            if (TestNumber < 10)
            {
                this.TestNumber++;
                
                this.lblCount.Content = TestNumber.ToString(); 
            }
            CheckButtonEnable();
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            if (TestNumber > 0)
            {
                this.TestNumber--;
                this.lblCount.Content = TestNumber.ToString();
            }
            CheckButtonEnable();
        }

        private void CheckButtonEnable()
        {
            if (this.TestNumber == 10)
                this.button_plus.IsEnabled = false;
            else
                this.button_plus.IsEnabled = true;

            if (this.TestNumber == 0)
                this.button_minus.IsEnabled = false;
            else
                this.button_minus.IsEnabled = true;
        }

        private void button_subwindow_Click(object sender, RoutedEventArgs e)
        {
            SubWindow subWindow = new SubWindow();
            subWindow.Show();
        }
    }
}
