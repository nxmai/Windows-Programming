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

namespace EnglishByImages
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

        TextBlock textBlock = new TextBlock();
        int start = 0;

        private void DisplayNextRandomImage()
        {
            Random _rng = new Random();

            var images = new string[]
            {
                "avocado.jpg",
                "beefsteak.jpg",
                "bread.jpg",
                "cucumber.jpg",
                "icecream.jpg",
                "onion.jpg",
                "potato.jpg",
                "strawberry.jpg",
                "tomato.jpg"
            };

            int index = _rng.Next(images.Length);
            var bitmap = new BitmapImage(
                new Uri($"Images/{images[index]}",
                UriKind.Relative)
                );
            EnglishImage.Source = bitmap;

            var text = new string[]
            {
                "AVOCADO (n): TRÁI BƠ",
                "BEEFSTEAK (n): BÒ BÍT TẾT",
                "BREAD (n): BÁNH MÌ",
                "CUCUMBER (n): DƯA LEO",
                "ICECREAM (n): KEM",
                "ONION (n) HÀNH TÂY",
                "POTATO (n): KHOAI TÂY",
                "STRAWBERRY (n): DÂU TÂY",
                "TOMATO (n): CÀ CHUA"
            };

            

            textBlock.Text = text[index];
            textBlock.Height = 500;
            textBlock.Width = 900;
            double left = 80, top = 15, right = 30, bottom = 40;
            textBlock.Margin = new Thickness(left, top, right, bottom);
            textBlock.FontSize = 20;
            
            

            LayoutRoot.Children.Add(textBlock);
            

        }

        private void infoNextButton(
            object sender, RoutedEventArgs e)
        {
            if (start == 0)
            {
                return;
            }

            LayoutRoot.Children.Remove(textBlock);
            DisplayNextRandomImage();

        }

        private void infoStartButton(
            object sender, RoutedEventArgs e)
        {
            if(start == 1)
            {
                return;
            }

            start = 1;
            DisplayNextRandomImage();
        }
    }
}
