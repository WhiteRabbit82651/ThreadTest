using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreadTest.ViewModels
{
    public class PageBViewModel : ViewModelBase
    {
        public PageBViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Page B";
        }
    }
}
