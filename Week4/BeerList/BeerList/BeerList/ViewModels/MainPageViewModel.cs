using BeerList.Models;
using BeerList.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BeerList.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //private readonly ISeriesService _seriesService;
        private readonly IBeersService _beersService;
        //public MainPageViewModel(INavigationService navigationService, ISeriesService seriesService)
        public MainPageViewModel(INavigationService navigationService, IBeersService beersService)
            : base(navigationService)
        {
            _beersService = beersService;
            //_seriesService = seriesService;
            Title = "Cold Beer List";
            //SeriesList = new ObservableCollection<Serie>();
            BerrsList = new ObservableCollection<Beers>();
            GetBerrsFormAPI();

            //GetSeriesFromAPI();
        }
        #region BerrsList
        private ObservableCollection<Beers> berrsList;

        public ObservableCollection<Beers> BerrsList
        {
            get { return berrsList; }
            set { SetProperty(ref berrsList, value); }

        }
        #endregion

        //private ObservableCollection<Serie> seriesList;
        //public ObservableCollection<Serie> SeriesList
        //{
        //    get { return seriesList; }
        //    set { SetProperty(ref seriesList, value); }
        //}
        private Beers berrs;

        public Beers Berrs
        {
            get { return berrs; }
            set
            {
                SetProperty(ref berrs, value);
                if (value != null)
                {
                    ViewDetails.Execute();
                }
            }
        }
        //private Serie serie;
        //public Serie Serie
        //{
        //    get { return serie; }
        //    set
        //    {
        //        SetProperty(ref serie, value);
        //        if (value != null)
        //        {
        //            ViewDetails.Execute();
        //        }
        //    }
        //}

        //cmdfull
        private DelegateCommand viewDetails;
        public DelegateCommand ViewDetails =>
           viewDetails ?? (viewDetails = new DelegateCommand(ExecuteViewDetailsAsync));

        async void ExecuteViewDetailsAsync()
        {
            //Go to the next page...
            var parameters = new NavigationParameters();
            parameters.Add("model", Berrs);
            await NavigationService.NavigateAsync("DetailsPage", parameters);
        }
        //async void ExecuteViewDetailsAsync()
        //{
        //    //Go to the next page...
        //    var parameters = new NavigationParameters();
        //    parameters.Add("model", Serie);
        //    await NavigationService.NavigateAsync("DetailsPage", parameters);
        //}

        async void GetBerrsFormAPI()
        {
            IsRunning = true;
            var objBerrs = await _beersService.GetAllBeersAsync();
            IsRunning = false;
            foreach (var item in objBerrs)
            {
                BerrsList.Add(item);
            }
        }
        //async void GetSeriesFromAPI()
        //{
        //    IsRunning = true;
        //    var result = await _seriesService.GetAllSeriesAsync();
        //    IsRunning = false;
        //    foreach (var item in result)
        //    {
        //        SeriesList.Add(item);
        //    }
        //}
    }
}
