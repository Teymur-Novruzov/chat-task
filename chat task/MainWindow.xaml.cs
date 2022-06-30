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

namespace chat_task
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

        private void sent_btn_Click(object sender, RoutedEventArgs e)
        {
            //list_box_messages.Items.Add(DateTime.Now.ToShortDateString()+"                                                       "+message_txb.Text.ToString());
            TextBlock textBlock = new TextBlock();
            textBlock.Text = message_txb.Text;
            textBlock.FontSize = 20;
            textBlock.Foreground = Brushes.White;

            string time = DateTime.Now.ToShortDateString();

            list_box_messages.Items.Add(time + "                                                 " + textBlock.Text);
            
        }
    }
}
