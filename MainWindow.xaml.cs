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

namespace Final_Project_Contant_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonName.Text = "Bobby Connolly";

            Address1.Text = "123 Sherbrooke St West";

            Address2.Text = "Apt 5";

            PostalCode.Text = "H3H 2P2";
           

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //PersonName.Text = string.Empty;

            //Address1.Text = string.Empty;

            //Address2.Text = string.Empty;

            //PostalCode.Text = string.Empty;


            foreach (var ctrl in Grid.Children)
            {
              
                if (ctrl is TextBox txt)
                {
                    txt.Text = string.Empty;
                }

            }

        }
    }
}
;