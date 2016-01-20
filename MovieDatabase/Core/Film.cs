using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Film
    {
        public ObjectId _id
        {
            get;
            set;
        }

        public Film()
        {
            Genres = new List<Genre>();
            Schauspieler = new List<string>();
            Sprachen = new List<string>();
        }
        public string Name
        {
            get;
            set;
        }

        public List<Genre> Genres
        {
            get;
            set;
        }

        public List<string> Schauspieler
        {
            get;
            set;
        }

        public string Regisseur
        {
            get;
            set;
        }

        public int Erscheinungsjahr
        {
            get;
            set;
        }

        public List<string> Sprachen
        {
            get;
            set;
        }

        public string Auflösung
        {
            get;
            set;
        }

        public string Storyline
        {
            get;
            set;
        }
    }
}
