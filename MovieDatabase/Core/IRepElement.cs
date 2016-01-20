using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IRepElement
    {
        ObjectId _id
        {
            get;
            set;
        }
        Guid ID
        {
            get;
            set;
        }

    }
}
