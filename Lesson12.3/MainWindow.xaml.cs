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

namespace Lesson12._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler eventAdd;
        public event EventHandler eventSub;
        public event EventHandler eventMul;
        public event EventHandler eventDiv;
        public event EventHandler eventEqual;
        public MainWindow()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            eventAdd.Invoke(sender, e);
        }

        private void Btn_Sub_Click(object sender, RoutedEventArgs e)
        {
            eventSub.Invoke(sender, e);
        }

        private void Btn_Mul_Click(object sender, RoutedEventArgs e)
        {
            eventMul.Invoke(sender, e);
        }

        private void Btn_Div_Click(object sender, RoutedEventArgs e)
        {
            eventDiv.Invoke(sender, e);
        }

        private void Btn_Equally_Click(object sender, RoutedEventArgs e)
        {
            eventEqual.Invoke(sender, e);
        }
    }
}
