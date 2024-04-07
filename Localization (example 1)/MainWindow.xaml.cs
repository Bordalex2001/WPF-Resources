using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
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
        }

        private void chngLngBtn_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary currentDictionary = Application.Current.Resources.MergedDictionaries[0];
            if (currentDictionary.Source != null)
            {
                string currentUri = currentDictionary.Source.ToString();
                if (currentUri.EndsWith(".en-US.xaml"))
                {
                    Uri changedUri = new Uri("Resources/Dictionary.uk-UA.xaml", UriKind.Relative);
                    ResourceDictionary changedDictionary = new ResourceDictionary { Source = changedUri };
                    Application.Current.Resources.MergedDictionaries[0] = changedDictionary;
                }
                else if (currentUri.EndsWith(".uk-UA.xaml"))
                {
                    Uri changedUri = new Uri("Resources/Dictionary.en-US.xaml", UriKind.Relative);
                    ResourceDictionary changedDictionary = new ResourceDictionary { Source = changedUri };
                    Application.Current.Resources.MergedDictionaries[0] = changedDictionary;
                }
            }
        }
    }
}