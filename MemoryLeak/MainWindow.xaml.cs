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
            int index = ExampleListBox.SelectedIndex;
            if (index < 0) return;
            index++;

            if (index == 1)
            {
                Example1 window = new Example1();
                window.Show();
            }

            if (index == 2)
            {
                Example2 window = new Example2();
                ExampleTextBox.TextChanged += window.OnTextChanged;
                window.Show();
            }

            if (index == 3)
            {
                
                Example3 window = new Example3();
                window.Show();
            }

            if (index == 4)
            {

                Example4 window = new Example4();
                window.Show();
            }

            if (index == 5)
            {
                Example5 window = new Example5();
                window.Show();
            }
        }

        private void GCButton_OnClick(object sender, RoutedEventArgs e)
        {
            GC.Collect();
        }
    }
}