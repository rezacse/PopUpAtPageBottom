using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PopUpAtBottom.Resources;
using System.Windows.Controls.Primitives;

namespace PopUpAtBottom
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor

        Popup popUP = new Popup();
        public MainPage()
        {
            InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
        }

        private void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (popUP.IsOpen)
                popUP.IsOpen = false;
            popUP.Child = new PopUP();
            popUP.VerticalOffset = e.NewSize.Height + 30 - 50;
            popUP.IsOpen = true;
        }        
    }
}