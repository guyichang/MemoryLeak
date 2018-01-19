using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example5.xaml
    /// </summary>
    public partial class Example5
    {
        private readonly List<string> _bigList = ExampleHelper.BigList();

        /// <summary>
        /// 产生条件：注册了静态事件，而静态对象是永远存在内存中的
        /// 对策：清除静态事件的引用
        /// </summary>
        public Example5()
        {
            InitializeComponent();
        }
    }
}
