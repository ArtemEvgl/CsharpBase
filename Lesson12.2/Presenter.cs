using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Lesson12._2
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;
        

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();

            mainWindow.timer = new DispatcherTimer();
            mainWindow.timer.Interval = TimeSpan.FromSeconds(1);
            mainWindow.timer.Tick += DispatcherTimer_Tick;

            mainWindow.eventDrop += MainWindow_eventDrop;
            mainWindow.eventStart += MainWindow_eventStart;
            mainWindow.eventStop += MainWindow_eventStop;
        }

        private void MainWindow_eventStop(object sender, EventArgs e)
        {
            mainWindow.timer.Stop();
        }

        private void MainWindow_eventStart(object sender, EventArgs e)
        {
            mainWindow.timer.Start();
        }

        private void MainWindow_eventDrop(object sender, EventArgs e)
        {
            
            mainWindow.Label_Seconds.Content = model.Reset();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            mainWindow.Label_Seconds.Content = model.Tick();
        }


    }
}
