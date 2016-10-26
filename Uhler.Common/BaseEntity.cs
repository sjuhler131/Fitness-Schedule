using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhler.Common
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

        public abstract string Name { get; }

        public abstract string GetName();

        public virtual string GetNameExample()
        {
            return "Name from base class";
        }
        
    }
}
