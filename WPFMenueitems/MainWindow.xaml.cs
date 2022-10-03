using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xaml;

namespace WPFMenueitems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string currentDirectory = Directory.GetCurrentDirectory();
            string menufilepath = currentDirectory + "\\MenuStruc.xaml";
            if (File.Exists(menufilepath))
            {
                string fileText = File.ReadAllText(menufilepath);
                Object obj = XamlServices.Parse(fileText);
                Menu adf = new Menu();
                adf.Loaded += Lo12;

                dockPanel1.Children.Add(obj as UIElement);
            }
            else { MessageBox.Show("ERROR: File not found"); }
            for (int i = 0; i < dockPanel1.Children.Count; i++)
            { 
                //internal System.Windows.Controls.MenuItem benutzer1;
                //var mitem = Benutzer1;
                if (dockPanel1.Children[i].GetType().ToString() == "Benutzer1") MessageBox.Show("drrrrr");
                //MessageBox.Show(mitem.Tag.ToString());
            }
        }
        public void Lo12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mitem.Tag.ToString()");
        }
    }
}
