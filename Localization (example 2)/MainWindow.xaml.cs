using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Reflection;
using System.Globalization;
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
using Localization__example_2_.Properties.Resources;
using System.Threading;

namespace WPF_Resources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += UpdateUI;
        }
        
        private void UpdateUI(object sender, EventArgs e)
        {
            mainWin.Title = Dictionary.winTitle;
            nameLbl.Content = Dictionary.nameLbl_text;
            surnameLbl.Content = Dictionary.surnameLbl_text;
            phoneLbl.Content = Dictionary.phoneLbl_text;
            okBtn.Content = Dictionary.okBtn_text;
            cancelBtn.Content = Dictionary.cancelBtn_text;
            chngLngBtn.Content = Dictionary.chngLngBtn_text;
        }

        private void chngLngBtn_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            if (currentCulture.Name == "uk-UA")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }
            else if (currentCulture.Name == "en-US")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            }
            UpdateUI(sender, e);
        }
    }
}