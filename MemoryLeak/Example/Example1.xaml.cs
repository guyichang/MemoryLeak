using System;
using System.Windows.Threading;
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
        /// 产生条件：使用了计时器，而计时器在WPF中是Dispatcher里面的一个列表对象中的一个对象，而Dispatcher全局存在
        /// Start的时候会将此计时器加入到计时器列表中_dispatcher.AddTimer(this);而Stop时会移除_dispatcher.RemoveTimer(this);
        /// 对策：及时停止计时器
        /// </summary>
        public Example1()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}