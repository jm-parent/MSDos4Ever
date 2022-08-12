using MSDos4Ever.ViewModels;

namespace MSDos4Ever;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }


}

