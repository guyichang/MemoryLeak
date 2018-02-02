using System;
using System.Windows;
using MemoryLeak.Example;

namespace MemoryLeak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchButton_OnClick(object sender, RoutedEventArgs e)
        {
            switch (ExampleListBox.SelectedIndex)
            {
                case 0:
                    {
                        Example1 window = new Example1();
                        window.Show();
                        break;
                    }
                case 1:
                    {
                        Example2 window = new Example2();
                        window.Show();
                        break;
                    }
                case 2:
                    {
                        Example3 window = new Example3();
                        window.Show();
                        break;
                    }
                case 3:
                    {
                        Example4 window = new Example4();
                        window.Show();
                        break;
                    }
                case 4:
                    {
                        Example5 window = new Example5();
                        window.Show();
                        break;
                    }
            }
        }
        private void GCButton_OnClick(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}