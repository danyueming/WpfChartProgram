﻿using HeBianGu.WPF.EChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfChartDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        MainWindowViewModel _vm = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = _vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<ICurveEntitySource> collection = new List<ICurveEntitySource>();
            _vm.MinValue = 0;
            _vm.MaxValue = 10;
            _vm.Collection = collection;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _vm.RefreshCurveData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            this.btn_start.IsEnabled = false;
            _vm.RefreshCardiogramCurve();

           
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            _vm.StopFlag = true;

            this.btn_start.IsEnabled = true;
        }

        private void btn_print_Click(object sender, RoutedEventArgs e)
        {
            PrintProvider.PrintGrid(this.grid_all);
        }
    }
}
