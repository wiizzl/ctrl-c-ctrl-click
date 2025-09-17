using CtrlCCtrlClick.ViewModels;

namespace CtrlCCtrlClick;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}