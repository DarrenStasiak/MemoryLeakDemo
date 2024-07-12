using CommunityToolkit.Mvvm.Messaging;
using MemoryLeakDemo.ViewModels;

namespace MemoryLeakDemo.Views;

public partial class OtherPage
{
	public OtherPage(OtherPageViewModel viewModel)
	{
        GC.Collect();

		BindingContext = viewModel;
        InitializeComponent();
	}

    ~OtherPage()
	{

	}
}