using System.Collections.Generic;
using System.Windows.Controls;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example2Window.xaml
    /// </summary>
    public partial class Example2
    {
        private readonly List<string> _bigList = ExampleHelper.BigList();

        /// <summary>
        /// 产生条件：被长生命周期的对象引用，造成了泄漏
        /// 对策1：在自己生命周期结束的时候，取消长生命周期对象对自己的引用
        /// 对策2：使用非直接的事件引用方式，参考弱引用
        /// </summary>
        public Example2()
        {
            InitializeComponent();
        }

        public void OnTextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
