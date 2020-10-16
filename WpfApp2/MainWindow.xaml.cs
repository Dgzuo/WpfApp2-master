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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n = 15;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(Number.Text);
            switch(n)
            {
            case 048:
                    {
                        int minute = int.Parse(Minute.Text);
                        
                        n *= minute;
                        resault.Text = "Одесса" + " " + n.ToString() + "руб";
                    }
                    break;
            }
        }
    }
}
