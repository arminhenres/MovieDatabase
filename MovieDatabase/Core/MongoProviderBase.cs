using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class MongoProviderBase<TElement> : IProvider<TElement> where TElement : IRepElement
    {
        protected string _ip;

        protected int _port;

        protected MongoClient _client;

        protected MongoServer _server;

        protected MongoDatabase _database;

        protected MongoCollection<TElement> _collection;

        protected bool _isInitialized;

        public MongoProviderBase(string ip, int port)
        {
            _ip = ip;
            _port = port;
            _isInitialized = false;
        }

        public void Intialize()
        {
            _client = new MongoClient(String.Format("mongodb://{0}:{1}",_ip,_port));
            _server = _client.GetServer();
            _database = _server.GetDatabase("Media");
            _collection = _database.GetCollection<TElement>(typeof(TElement).ToString());
            _isInitialized = true;
        }

        public abstract IEnumerable<TElement> GetElements();

        public abstract void SaveElement(TElement element);

        public abstract void DeleteElement(TElement element);
    }
}
