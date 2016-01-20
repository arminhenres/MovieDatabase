using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IProvider<TElement>  where TElement : IRepElement
    {
        IEnumerable<TElement> GetElements();

        void SaveElement(TElement element);

        void DeleteElement(TElement element);
    }
}
