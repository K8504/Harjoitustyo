﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Platform
{
    public sealed partial class Bird : UserControl
    {

        // location
        public double StartLocationXX { get; set; }
        public double StartLocationYY { get; set; }
        private double Speed = 7.0;
        int EndLocationY = 550;
        public Bird()
        {
            this.InitializeComponent();
        }
        public void MoveDown()
        {
            StartLocationYY += Speed;

            if (StartLocationYY >= EndLocationY || StartLocationYY <= 339)
            {
                Speed = (-1) * Speed;
            }

        }

        public void UpdateLocation()
        {
            SetValue(Canvas.LeftProperty, StartLocationXX);
            SetValue(Canvas.TopProperty, StartLocationYY);
        }
    }
}
