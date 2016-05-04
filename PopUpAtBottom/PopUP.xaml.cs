using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PopUpAtBottom
{
    public partial class PopUP : UserControl
    {
        public PopUP()
        {
            InitializeComponent();
            //LayoutRoot.Height = 50;
            LayoutRoot.Width = App.Current.Host.Content.ActualWidth;
        }
    }
}
