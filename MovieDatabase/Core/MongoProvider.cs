using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MongoProvider<TElement> : MongoProviderBase<TElement>
    {
        public MongoProvider(string ip, int port) : base(ip,port)
        {
            
        }
        public IEnumerable<TElement> GetElements()
        {
            List<TElement> elements = new List<TElement>();
            return _collection.FindAllAs<TElement>().ToList<TElement>();
        }

        public override void SaveElement(TElement element)
        {
            _collection.Insert(element);
        }

        public override void DeleteElement(TElement element)
        {
            throw new NotImplementedException();
        }
    }
}
