using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MemoryLeakDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeakDemo.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {

        }

        [RelayCommand]
        private async Task OpenFormWindow()
        {
            await Shell.Current.GoToAsync("///OtherPage");
        }

    }
}
