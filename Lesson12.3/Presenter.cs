using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._3
{
    class Presenter
    {
        MainWindow mainWindow;
        Model model;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();

            mainWindow.eventAdd += MainWindow_eventAdd;
            mainWindow.eventDiv += MainWindow_eventDiv;
            mainWindow.eventEqual += MainWindow_eventEqual;
            mainWindow.eventMul += MainWindow_eventMul;
            mainWindow.eventSub += MainWindow_eventSub;
        }

        private void MainWindow_eventSub(object sender, EventArgs e)
        {
            mainWindow.TextBox_Result.Text = model.Calculate(mainWindow.TextBox_Result.Text, OperationEnum.Sub);            
        }

        private void MainWindow_eventMul(object sender, EventArgs e)
        {
            mainWindow.TextBox_Result.Text = model.Calculate(mainWindow.TextBox_Result.Text, OperationEnum.Mul);
        }

        private void MainWindow_eventEqual(object sender, EventArgs e)
        {
            mainWindow.TextBox_Result.Text = model.GetResult(mainWindow.TextBox_Result.Text).ToString();
        }

        private void MainWindow_eventDiv(object sender, EventArgs e)
        {
            mainWindow.TextBox_Result.Text = model.Calculate(mainWindow.TextBox_Result.Text, OperationEnum.Div);
        }

        private void MainWindow_eventAdd(object sender, EventArgs e)
        {
            mainWindow.TextBox_Result.Text = model.Calculate(mainWindow.TextBox_Result.Text, OperationEnum.Add);
        }

        
    }

    enum OperationEnum
    {
        Sub,
        Mul,
        Div,
        Add
    }
}
