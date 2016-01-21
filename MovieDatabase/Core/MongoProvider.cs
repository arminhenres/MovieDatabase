using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Core
{
    public class MongoProvider<TElement> : MongoProviderBase<TElement> where TElement : IRepElement
    {
        public MongoProvider(string ip, int port) : base(ip,port)
        {
            
        }
        public override IEnumerable<TElement> GetElements()
        {
            List<TElement> elements = new List<TElement>();
            return _collection.FindAllAs<TElement>().ToList<TElement>();
        }

        public override void SaveElement(TElement element)
        {
            _collection.Insert<TElement>(element);            
        }           

        public override void DeleteElement(TElement element)
        {
            var query = new QueryDocument("ID", element.ID);
            _collection.Remove(query);
        }

        public bool AlreadyAvailable(TElement element)
        {
            QueryDocument query = new QueryDocument("ID", element.ID);
            var x = _collection.FindOneAs<TElement>(query);
            bool result = false;
            if(x != null)
            {
                result = true;
            }
            return result;
        }
    }
}
