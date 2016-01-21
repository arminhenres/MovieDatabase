using Core;
using Ressources;
using Ressources.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ViewModel : ViewModelBase
    {

        MongoProvider<Film> filmprovider;
        public ViewModel()
        {
            
            UploadNewInfoButton = new ActionCommand(UploadNewInfo);
            filmprovider = new MongoProvider<Film>("localhost",27017);
            filmprovider.Intialize();
            filmprovider.SaveElement(new Film() { Name = "Hateful Eight", Regisseur = "Tarantino", Pfad = "noch nicht da" });
            filmprovider.SaveElement(new Film() { Name = "Herr der Ringe", Regisseur = "Peter Jackson", Pfad = "Auf der Festplatte ;)" });
            filmprovider.SaveElement(new Film() { Name = "Star Wars", Regisseur = "JJ Abrams", Pfad = "Auch auf der FP" });
            Filme = new ObservableCollection<Film>(filmprovider.GetElements());

        }

        public ActionCommand UploadNewInfoButton
        {
            get;
            set;
        }

        public ObservableCollection<Film> Filme
        {
            get;
            set;
        }

        private void UploadNewInfo()
        {
            var x = filmprovider.AlreadyAvailable(new Film());
        }
    }
}
