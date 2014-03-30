using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CounterApp.Resources;

namespace CounterApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        int counter = 0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void CountButton_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            counter++;
            CountText.Text = counter.ToString("N0");
        }

        private void ResetButton_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            counter = 0;
            CountText.Text = counter.ToString("N0");
        }
    }
}