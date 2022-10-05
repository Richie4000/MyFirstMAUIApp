using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyFirstMauiApp.Resources.ViewModel
{
    public partial class MainViewModel : ObservableObject 
    {
        string Text;
        ObservableCollection<string> Items;

        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        
        [RelayCommand]

        void add()
        {
            Text = string.Empty;
        }

    }
}
