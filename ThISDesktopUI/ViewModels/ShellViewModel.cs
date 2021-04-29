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
        private LoginViewModel _loginVM;
        private IEventAggregator _events;
        private SeasonsViewModel _seasonVM;

        public ShellViewModel(LoginViewModel loginVM, IEventAggregator events, SeasonsViewModel seasonVM)
        {
            _events = events;
            _loginVM = loginVM;
            _seasonVM = seasonVM;

            _events.Subscribe(this);
            
            
            ActivateItem(_loginVM);
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_seasonVM);
        }
    }
}
