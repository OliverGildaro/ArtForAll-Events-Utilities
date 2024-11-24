using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtForAll.GenericsLinqCollections.reflection.interfaces
{
    public interface ILogger
    {
        void Log<T>(T input);
    }
}
