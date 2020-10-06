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
using System.Timers;
using System.Windows.Threading;

namespace InspirationalQuotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Random rng = new Random();
        //private System.Timers.Timer _timer;

        public MainWindow()
        {
            InitializeComponent();
        }
        int start = 0;

        void DisplayNextRandomImage()
        {

            Random _rng = new Random();

            var quotes = new string[]
            {
                "quote01.jpg",
                "quote02.jpg",
                "quote03.jpg",
                "quote04.jpg",
                "quote05.jpg",
                "quote06.jpg",
                "quote07.jpg",
                "quote08.jpg",
                "quote09.jpg",
                "quote10.jpg"
            };

            int index = _rng.Next(quotes.Length);
            var bitmap = new BitmapImage(
                new Uri($"Images/{quotes[index]}",
                UriKind.Relative)
                );
            QuotesImage.Source = bitmap;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            DisplayNextRandomImage();
        }

        private void StartButton(
            object sender, RoutedEventArgs e)
        {
            if (start == 1)
                return;
            start = 1;

            DisplayNextRandomImage();
        }

        private void InfoButton_Click(
            object sender, 
            RoutedEventArgs e)
        {
            if (start == 0)
                return;

            DisplayNextRandomImage();

            Dispatcher disp = QuotesImage.Dispatcher;
            DispatcherTimer t = new DispatcherTimer(TimeSpan.FromSeconds(3), DispatcherPriority.Normal, timer_Tick, disp);
            t.Start();
        }
    }
}
