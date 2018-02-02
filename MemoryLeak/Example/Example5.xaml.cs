using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example5.xaml
    /// </summary>
    public partial class Example5
    {
        //这里产生一个大的内存占用，约50MB，用于在任务管理器看到这个窗口Show出来以后，进程内存占用剧增的现象
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
