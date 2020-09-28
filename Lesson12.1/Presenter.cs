using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._1
{
    class Presenter
    {
        MainWindow mainWindow;
        Model model;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();

            mainWindow.MyEvent += MainWindow_MyEvent;
        }

        private void MainWindow_MyEvent(object sender, EventArgs e)
        {
            mainWindow.TextBox_Data.Text = model.SomeMethod(mainWindow.TextBox_Data.Text);
        }
    }
}
