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
using System.Windows.Threading;

namespace Lesson12._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public event EventHandler eventStart;
        public event EventHandler eventStop;
        public event EventHandler eventDrop;
        public DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            eventStart.Invoke(sender, e);
        }

        private void Btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            eventStop.Invoke(sender, e);
        }

        private void Btn_Drop_Click(object sender, RoutedEventArgs e)
        {
            eventDrop.Invoke(sender, e);
        }
    }
}
