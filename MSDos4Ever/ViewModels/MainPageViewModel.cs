namespace MSDos4Ever.ViewModels;

[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    [ObservableProperty]
    private string userName;

    [ObservableProperty]
    private string password;

    public MainPageViewModel()
    {

    }
}
