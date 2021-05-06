using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThISDesktopUI.Library.Api;
using ThISDesktopUI.Library.Models;
using ThISDesktopUI.Views;

namespace ThISDesktopUI.ViewModels
{
    public class SeasonsViewModel : Screen
    {
        private ISeasonEndpoint _seasonendpoint;
        private BindingList<SeasonItemModel> _seasons;
        private string _seasonFullName;
        private string _seasonShortName;

        public SeasonsViewModel(ISeasonEndpoint seasonEndpoint)
        {
            _seasonendpoint = seasonEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadSeasons();
        }

        private async Task LoadSeasons() 
        {
            var ListOfSeasons = await _seasonendpoint.GetAll();
            SeasonsList = new BindingList<SeasonItemModel>(ListOfSeasons);
        }

        public BindingList<SeasonItemModel> SeasonsList
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
