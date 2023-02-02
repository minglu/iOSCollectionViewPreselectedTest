using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace iOSCollectionViewPreselectedTEST.ViewModel
{
    public partial class StateSelectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<object> states;

        [ObservableProperty]
        private ObservableCollection<object> selectedStates;

        public StateSelectionViewModel()
        {

            List<string> s = new List<string>()
            {
                "FL",
                "CA",
                "IN",
                "PA",
                "TX",
                "CO",
                "DE",
                "GA",
                "ID",
                "IL"
            };

            List<string> ss = new List<string>()
            {
                "FL",
                "PA",
                "GA"
            };

            States = new ObservableCollection<object>(s);
            SelectedStates = new ObservableCollection<object>(ss);
        }
    }
}

