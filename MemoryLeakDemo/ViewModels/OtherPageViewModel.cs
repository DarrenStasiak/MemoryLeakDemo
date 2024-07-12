using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeakDemo.ViewModels
{
    public partial class OtherPageViewModel : ObservableObject
    {
        public OtherPageViewModel() { }

        [RelayCommand]
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

    }
}
