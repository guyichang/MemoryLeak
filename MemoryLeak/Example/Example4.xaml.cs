using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example4.xaml
    /// </summary>
    public partial class Example4
    {
        private readonly List<string> _bigList = ExampleHelper.BigList();

        /// <summary>
        /// 产生条件：注册了静态事件，而静态对象是永远存在内存中的
        /// 对策：清除静态事件的引用
        /// </summary>
        public Example4()
        {
            InitializeComponent();

            ExampleHelper.LeakEvent += ExampleHelper_LeakEvent;
        }

        private void ExampleHelper_LeakEvent(object sender, System.EventArgs e)
        {
        }
    }
}