using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IProvider<TElement>
    {
        //IEnumerable<TElement> GetElements();

        void SaveElement(TElement element);

        void DeleteElement(TElement element);
    }
}
