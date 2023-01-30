using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndBroadcast
{
    public static class ExtensionMethod
    {
        public static IObserver<T> OnNext<T>(this IObserver<T> self, params T[] args)
        {
            foreach (var arg in args)
                self.OnNext(arg);
            return self;
        }
    }
}
