namespace iOSCollectionViewPreselectedTEST;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(CollectionViewPopupPage), typeof(CollectionViewPopupPage));
    }
}

