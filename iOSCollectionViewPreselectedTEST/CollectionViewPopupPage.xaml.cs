using System.Collections.Immutable;
using CommunityToolkit.Maui.Views;
using iOSCollectionViewPreselectedTEST.ViewModel;

namespace iOSCollectionViewPreselectedTEST;

public partial class CollectionViewPopupPage : Popup
{
    public CollectionViewPopupPage(StateSelectionViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;

        //if ((DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.MacCatalyst) && StateList != null)
        //{
        //    StateList.Behaviors.Add(new SelectionStateCollectionViewBehavior());
        //}
    }

    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        this.Close(false);
    }

    private void ApplyButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext != null && BindingContext is StateSelectionViewModel vm)
        {
            this.Close(StateList.SelectedItems?.Select(o => (string)o).ToImmutableSortedSet());
        }

    }
}
