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

namespace Hashtable_85
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {


                hashtable.Add(txt_key.Text, txt_value.Text);
               
                txt_value.Clear();
                txt_key.Clear();
      
        
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            

            hashtable.Remove(txt_key.Text);

            txt_value.Clear();
            txt_key.Clear();
        }

        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection_key = hashtable.Keys;
           
            foreach (string key in icollection_key)
            {
                MessageBox.Show(hashtable[key].ToString(),"Value");
            }
          
        }
    }
}
