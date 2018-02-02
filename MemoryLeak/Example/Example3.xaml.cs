using System.Windows;
using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example3.xaml
    /// </summary>
    public partial class Example3
    {
        //这里产生一个大的内存占用，约50MB，用于在任务管理器看到这个窗口Show出来以后，进程内存占用剧增的现象
        private readonly List<string> _bigList = ExampleHelper.BigList();

        /// <summary>
        /// 产生条件：被长生命周期的对象引用，造成了泄漏
        /// 对策1：在自己生命周期结束的时候，取消长生命周期对象对自己的引用
        /// 对策2：使用非直接的事件引用方式，参考弱引用
        /// </summary>
        public Example3()
        {
            InitializeComponent();

            Application.Current.MainWindow.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}