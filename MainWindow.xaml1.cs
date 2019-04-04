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

namespace mang
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

        private void BtGTNN_Click(object sender, RoutedEventArgs e)
        {
            string n =txtmang.Text;
            
            char[] c = n.ToCharArray();
            int[] ch = new int[c.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = (int)c[i] - '0';
            }
            int min = ch[0];
            for(int i=0;i<c.Length;i++)
            {
                if(min>ch[i])
                {
                    min = ch[i];
                }
            }
            txtGTNN.Text = min.ToString();

        }

        private void BtGTLN_Click(object sender, RoutedEventArgs e)
        {
            string n = txtmang.Text;
            char[] c = n.ToCharArray();
            int[] ch = new int[c.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = (int)c[i] - '0';
            }
            int max = ch[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (max < ch[i])
                {
                    max = ch[i];
                }
            }
            txtGTLN.Text = max.ToString();
        }
    }
}
