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

namespace BrainTease_3_30_17
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
            if (IsPalendrome(input_txt.Text))
            {
                answer.Content = "Yup";
            }
            else
            {
                answer.Content = "Nope";
            }
        }

        private Boolean IsPalendrome(String val)
        {
            var q = val.GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .Count(x=>IsOdd(x.Count));
           
            return !(q > 1);
        }

        private Boolean IsOdd(int val)
        {
            return val % 2 != 0;
        }
        
    }
}
