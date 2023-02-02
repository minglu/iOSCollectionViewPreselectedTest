using CommunityToolkit.Maui.Views;
using iOSCollectionViewPreselectedTEST.ViewModel;
using System.Collections.Immutable;

namespace iOSCollectionViewPreselectedTEST;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        var vm = new StateSelectionViewModel();

        var popup = new CollectionViewPopupPage(vm);

        popup.CanBeDismissedByTappingOutsideOfPopup = false;

        var result = await this.ShowPopupAsync(popup);

        if (result is IImmutableSet<string> selectedStates)
        {
            await DisplayAlert("Selected", string.Join(",", selectedStates), "OK");
        }
    }
}


