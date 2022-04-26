using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace progressbar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var totalCount = 67440;

            double totalProgress = 0;

            double totalCountRatio = 100.0/totalCount;

            foreach (int item in Enumerable.Range(1, 800))
            {
                double x = Math.Round(((Convert.ToDouble(item) / 800) * 100), 2);
                totalProgress += totalCountRatio;
                totalProgressText.Text = $"Total Progress ({Math.Round((totalProgress), 0)}%)";
                progress1Text.Text = $"{x}%";
                pbStatus1.Value = x;
                pbStatus.Value = totalProgress;

                progress1Text.Foreground = x >= 80 ? Brushes.FloralWhite : x >= 60 ? Brushes.Green : x >= 40 ? Brushes.YellowGreen : Brushes.Red;

                await Task.Delay(10);
                
            }

            foreach (int item in Enumerable.Range(1, 300))
            {
                double x = Math.Round(((Convert.ToDouble(item) / 300) * 100), 2);
                totalProgress += totalCountRatio;
                totalProgressText.Text = $"Total Progress ({Math.Round((totalProgress), 0)}%)";
                progress2Text.Text = $"{x}%";
                pbStatus2.Value = x;
                pbStatus.Value = totalProgress;

                progress2Text.Foreground = x >= 80 ? Brushes.FloralWhite : x >= 60 ? Brushes.Green : x >= 40 ? Brushes.YellowGreen : Brushes.Red;

                await Task.Delay(10);
            }

            foreach (int item in Enumerable.Range(1, 270))
            {
                double x = Math.Round(((Convert.ToDouble(item) / 270) * 100), 2);
                totalProgress += totalCountRatio;
                progress3Text.Text = $"{x}%";
                totalProgressText.Text = $"Total Progress ({Math.Round((totalProgress), 0)}%)";
                pbStatus3.Value = x;
                pbStatus.Value = totalProgress;

                progress3Text.Foreground = x >= 80 ? Brushes.FloralWhite : x >= 60 ? Brushes.Green : x >= 40 ? Brushes.YellowGreen : Brushes.Red;

                await Task.Delay(10);
            }

            foreach (int item in Enumerable.Range(1, 66070))
            {
                double x = Math.Round(((Convert.ToDouble(item) / 66070) * 100), 2);
                totalProgress += totalCountRatio;
                progress4Text.Text = $"{x}%";
                totalProgressText.Text = $"Total Progress ({Math.Round((totalProgress), 0)}%)";
                pbStatus4.Value = x;
                pbStatus.Value = totalProgress;

                progress4Text.Foreground = x >= 80 ? Brushes.FloralWhite : x >= 60 ? Brushes.Green : x >= 40 ? Brushes.YellowGreen : Brushes.Red;

                await Task.Delay(10);
            }
        }
	}
}
