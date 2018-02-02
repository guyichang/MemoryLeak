using System.Collections.Generic;

namespace MemoryLeak.Example
{
    /// <summary>
    /// Interaction logic for Example2Window.xaml
    /// </summary>
    public partial class Example2
    {
        //这里产生一个大的内存占用，约50MB，用于在任务管理器看到这个窗口Show出来以后，进程内存占用剧增的现象
        private readonly List<string> _bigList = ExampleHelper.BigList();

        /// <summary>
        /// 产生条件1：数据绑定的Path指向对象X的属性P
        /// 产生条件2：对象X能直接或者间接的引用到数据绑定的Target
        /// 产生条件3：属性P通过PropertyDescriptor对象访问，而不是DependencyProperty对象或者PropertyInfo对象访问
        /// 对策1：通过DependencyProperty对象来访问属性P
        /// 对策2：在对象X上实现INotifyPropertyChanged
        /// 对策3：设置数据绑定Mode为OneTime
        /// 
        /// WPF的DataBinding的设计是配合Dependency Properties或者实现了INotifyPropertyChanged的类来工作的，
        /// 从2007年发布以后就一直如此，不符合上述条件的绑定会通过PropertyDescriptor来绑定，这会创建强对象引用，而这会阻止这些对象被垃圾回收
        /// 
        /// 在通常来说，你不应该直接在普通类上创建数据绑定，跟随MVVM模式，实现INotifyPropertyChanged接口才是Binding的正确使用方式
        /// 
        /// </summary>
        public Example2()
        {
            InitializeComponent();

            //此举也会造成内存泄漏：
            //var dp = DependencyPropertyDescriptor.FromProperty(ActualWidthProperty, typeof(Window));
            //dp.AddValueChanged(this, (s, e) => { });

            //此举也会造成内存泄漏：
            //var tp = TypeDescriptor.GetProperties(typeof(RowDefinitionCollection))["Count"];
            //tp.AddValueChanged(MyGrid.RowDefinitions, (s, e) => { });
        }
    }
}