using Core;
using Ressources;
using Ressources.MVVM;
using System;
using System.Collections.Generic;
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
        }

        public ActionCommand UploadNewInfoButton
        {
            get;
            set;
        }

        private void UploadNewInfo()
        {
            var x = filmprovider.AlreadyAvailable(new Film());
            x.ToString();
        }
    }
}
