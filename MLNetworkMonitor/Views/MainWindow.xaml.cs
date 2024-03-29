﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Diagnostics;

namespace MLNetworkMonitor.Views
{
    public class MainWindow : FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);            
        }
    }
}
