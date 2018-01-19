using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Example1
    {
        private readonly List<string> _bigList = ExampleHelper.BigList();

        /// <summary>
        /// 一切正常，内存可以正常回收
        /// </summary>
        public Example1()
        {
            InitializeComponent();
        }
    }
}
