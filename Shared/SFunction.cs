using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
{
    public static class SFunction
    {

        public static List<U> GetArrByPrototype<T, U>(List<T> items, string namePropGet)
        {
            List<U> l = new List<U>();
            foreach(T item in items)
            {
                l.Add((U)typeof(T).GetProperty(namePropGet).GetValue(item));
            }
            return l;
        }
        

        public static void SetTimeOut(Action action, int time)
        {
            System.Timers.Timer timer = new System.Timers.Timer(time);
            timer.AutoReset = false;
            timer.Elapsed += (a, t) => {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        public static void Resize<T>(this List<T> list, int size, T element = default(T))
        {
            int count = list.Count;

            if (size < count)
            {
                list.RemoveRange(size, count - size);
            }
            else if (size > count)
            {
                if (size > list.Capacity)   // Optimization
                    list.Capacity = size;

                list.AddRange(Enumerable.Repeat(element, size - count));
            }
        }

    }
}
