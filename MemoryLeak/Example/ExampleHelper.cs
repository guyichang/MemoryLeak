using System;
using System.Collections.Generic;

namespace MemoryLeak.Example
{
    public static class ExampleHelper
    {
        public static List<string> BigList()
        {
            List<string> big = new List<string>();
            for (int i = 0; i < 500000; i++)
            {
                big.Add(Guid.NewGuid().ToString());
            }
            return big;
        }

        public static event EventHandler LeakEvent;
        public static void RaiseLeakEvent()
        {
            LeakEvent?.Invoke(null, EventArgs.Empty);
        }
    }
}