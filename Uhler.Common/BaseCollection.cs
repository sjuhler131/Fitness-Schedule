using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;

namespace Uhler.Common
{
    public abstract class BaseCollection<T> : Collection<T>, IList<T>
    {
        protected BaseCollection() : base(new List<T>()) { }
    }
}
