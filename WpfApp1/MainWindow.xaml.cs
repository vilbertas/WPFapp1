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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string partOne = "";
        private string partTwo = "";
       // string result = "";
        private string action;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void num1btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            resultBox.Text = resultBox.Text + buttonValue;
            partOne = partOne + buttonValue;
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + ((Button)sender).Content.ToString();
            partTwo = partOne;
            partOne = "";
            action = ((Button)sender).Content.ToString();
        }

        private void executeBtn_Click(object sender, RoutedEventArgs e)
        {
            int partOneNumber = int.Parse(partOne);
            int partTwoNumber = int.Parse(partTwo);

            switch (action)
            {
                case "+":
                    resultBox.Text = (partTwoNumber + partOneNumber).ToString();
                    break;
                case "-":
                    resultBox.Text = (partTwoNumber - partOneNumber).ToString();
                    break;
                case "*":
                    resultBox.Text = (partTwoNumber * partOneNumber).ToString();
                    break;
                case "/":
                    resultBox.Text = (partTwoNumber / partOneNumber).ToString();
                    break;
            }

          //  if (action == "+")
          //  {
          //      resultBox.Text = (partTwoNumber + partOneNumber).ToString();
          //  }
           // else if (action == "-")
           // {
           //     resultBox.Text = (partTwoNumber - partOneNumber).ToString();
           // }
           // else if (action == "*")
            //{
           //     resultBox.Text = (partTwoNumber * partOneNumber).ToString();
           // }
           // else if (action == "/")
           // {
           //     resultBox.Text = (partTwoNumber / partOneNumber).ToString();
           // }

            partOne = resultBox.Text;
        }

        private void multiplyBtn_click(object sender, RoutedEventArgs e)
        {

        }
    }
}