using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CtrlCCtrlClick.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name;
    
    [ObservableProperty]
    private int _age;
    
    public MainViewModel()
    {
        Name = "John Doe";
        Age = 25;
    }
    
    [RelayCommand]
    public void IncrementAge()
    {
        Age++;
    }
}