﻿using System;
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
        private bool isSignSelected = false;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void num1btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            resultBox.Text = resultBox.Text + buttonValue;
            partOne = partOne + buttonValue;
            isSignSelected = false;
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            if (isSignSelected)
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1).ToString();
            }
            else
            {
                partTwo = partOne;
                partOne = "";
            }
            resultBox.Text = resultBox.Text + ((Button)sender).Content.ToString();

            isSignSelected = true;
            action = ((Button)sender).Content.ToString();
            

        }

        private void executeBtn_Click(object sender, RoutedEventArgs e)
        {
            int partOneNumber = int.Parse(partOne);
            int partTwoNumber = int.Parse(partTwo);

            Arithmetics arithmetics = new Arithmetics();
            try
            {
                resultBox.Text = arithmetics.Calculate(partTwoNumber, partOneNumber, action).ToString();
            }
            catch (DivideByZeroException ex)
            {
                resultBox.Text = "Division by 0 not allowed";
            }
            partOne = resultBox.Text;
        }
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = String.Empty;
            partOne = "";
        }
    }
}