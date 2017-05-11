using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZedaphPatreonTool
{
    class Helper
    {
        public static int Remove<T>(BindingList<T> list, T element, int index)
        {
            T mem = list[index];
            list.Remove(element);
            if (!list[index].Equals(mem))
                index--;
            return index;
        }
    }

    public class PredCompare<T> : IEqualityComparer<T>
    {
        Func<T, T, bool> pred;
        Func<T, int> hash;

        public PredCompare(Func<T, T, bool> pred = null, Func<T, int> hash = null)
        {
            this.pred = pred == null ? (x, y) => x.Equals(y) : pred;
            this.hash = hash == null ? (x) => x.GetHashCode() : hash;
        }

        public bool Equals(T x, T y)
        {
            return pred(x, y);
        }

        public int GetHashCode(T obj)
        {
            return hash(obj);
        }
    }
}
