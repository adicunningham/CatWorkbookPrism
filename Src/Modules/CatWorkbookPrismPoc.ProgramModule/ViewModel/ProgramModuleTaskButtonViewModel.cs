using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CatWorkbookPrismPoc.Infrastructure;
using CatWorkbookPrismPoc.ProgramModule.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;

namespace CatWorkbookPrismPoc.ProgramModule.ViewModel
{
    public class ProgramModuleTaskButtonViewModel : ViewModelBase, IProgramModuleTaskButtonViewModel, INavigationAware
    {
        #region Fields

        private bool? _isChecked;
        private IEventAggregator _eventAggregator;
        private IRegionManager _regionManager;

        #endregion

        #region Constructors

        public ProgramModuleTaskButtonViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
            this.Initialize();
        }

        #endregion

        #region Command Properties
        
        public ICommand ShowProgramModuleView { get; set; }

        #endregion

        #region INavigationAware Members

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        #endregion
        
        #region Administrative Properties

        public bool? IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                base.RaisePropertyChanged("IsChecekd");
                _isChecked = value;
                base.RaisePropertyChanged("IsChecked");
            }
        }

        #endregion

        #region Event Handlers

        public void OnNavigatedCompleted(string publisher)
        {
            
            // Exit if this module published the event
            if (publisher == "ProgramModule")
                return;

            // Otherwise, uncheck this button.
            IsChecked = false;
        }

        #endregion

        public void Initialize()
        {
            // Initialize command properties
            ShowProgramModuleView = new ProgramModuleViewCommand(this, _regionManager, _eventAggregator);

            // Initialize Administrative Properties
            IsChecked = false;

            // Subscribe to Composite Presentation Events
            var navigationCompletedEvent = _eventAggregator.GetEvent<NavigationCompletedEvent>();
            navigationCompletedEvent.Subscribe(OnNavigatedCompleted, ThreadOption.UIThread);
        }

    }
}
