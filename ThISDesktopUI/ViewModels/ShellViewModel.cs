using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using ThISDesktopUI.EventModels;

namespace ThISDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SeasonsViewModel _seasonVM;
        private SimpleContainer _container;

        public ShellViewModel(IEventAggregator events, SeasonsViewModel seasonVM,
            SimpleContainer container)
        {
            _events = events;
            _seasonVM = seasonVM;
            _container = container;

            _events.Subscribe(this);
            
            
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_seasonVM);
        }

        public void Handle(SeasonEvent message)
        {
            ActivateItem(_seasonVM);
        }
    }
}
