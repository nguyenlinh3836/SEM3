using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Exam.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<List> Lists;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { ImagePath = "Assets/1.png" });
            Icons.Add(new Icon { ImagePath = "Assets/2.png" });
            Icons.Add(new Icon { ImagePath = "Assets/3.png" });
            Icons.Add(new Icon { ImagePath = "Assets/4.png" });
            Icons.Add(new Icon { ImagePath = "Assets/5.png" });
            Icons.Add(new Icon { ImagePath = "Assets/6.png" });
            Icons.Add(new Icon { ImagePath = "Assets/7.png" });
            Icons.Add(new Icon { ImagePath = "Assets/8.png" });
            Lists = new ObservableCollection<List>();
        }

        private void NewImageButton_Click(object sender, RoutedEventArgs e)
        {
            Lists.Add(new List { Description = DescriptionTextBox.Text, Product = ProductTextBox.Text, ListImage = ((Icon)AvatarComboBox.SelectedValue).ImagePath });
            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;
            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
