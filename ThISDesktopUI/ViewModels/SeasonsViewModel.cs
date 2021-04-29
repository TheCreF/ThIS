using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThISDesktopUI.Views;

namespace ThISDesktopUI.ViewModels
{
    public class SeasonsViewModel : Screen
    {
        private BindingList<string> _seasons;
        private string _seasonFullName;
        private string _seasonShortName;

        public BindingList<string> SeasonsList
        {
            get { return _seasons; }
            set 
            { 
                _seasons = value;
                NotifyOfPropertyChange(() => SeasonsList);
            }
        }

        public string SeasonFullName
        {
            get { return _seasonFullName; }
            set 
            { 
                _seasonFullName = value;
                NotifyOfPropertyChange(() => SeasonFullName);
            }
        }

        public string SeasonShortName
        {
            get { return _seasonShortName; }
            set 
            { 
                _seasonShortName = value;
                NotifyOfPropertyChange(() => SeasonShortName);
            }
        }

        public bool CanSetAsCurrent {
            get 
            {
                bool output = false;

                //TODO : Inserire il codice per capire se una riga della DataGrid "SeasonsList" è stata selezionata
                output = true;

                return output;
            }
        }

        public void SetAsCurrent() 
        {

        }
    }
}
