using System.Windows;
using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example6.xaml
    /// </summary>
    public partial class Example6 : Window
    {
        private readonly List<string> _bigList = ExampleHelper.BigList();

        public Example6()
        {
            InitializeComponent();
        }
    }
}