using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ContextPlus.Configurator
{
    public class MainWindowViewModel : NotificationObject
    {
        private readonly IContextMenuService _contextmenuService;

        public MainWindowViewModel(IContextMenuService contextmenuService)
        {
            _contextmenuService = contextmenuService;
            _contextItems.Add(new ContextItemViewModel { Caption = "Copy full path", CommandLine = "copyFullPath %1" });
        }

        ObservableCollection<ContextItemViewModel> _contextItems = new ObservableCollection<ContextItemViewModel>();

        public ICommand AddCommand { get; private set; }
        
        public ICommand SaveCommand { get; private set; }
        
        public ICommand CancelCommand { get; private set; }

        public ObservableCollection<ContextItemViewModel> ContextItems
        {
            get
            {
                return _contextItems;
            }
            set
            {
                ChangeAndNotify(ref _contextItems, value, "ContextItems");
            }
        }
    }
}
