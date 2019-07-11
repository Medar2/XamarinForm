using BeerList.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BeerList.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase
    {
        private Beers beers;

        public Beers Beers
        {
            get { return beers; }
            set
            {
                SetProperty(ref beers, value);
            }
        }

        //private Serie serie;
        //public Serie Serie
        //{
        //    get { return serie; }
        //    set { SetProperty(ref serie, value); }
        //}

        public DetailsPageViewModel(INavigationService navigationService)
             : base(navigationService)
        {
            Title = "Beer Detail";
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            Beers = (Beers)parameters["model"];
        }

    }
}
