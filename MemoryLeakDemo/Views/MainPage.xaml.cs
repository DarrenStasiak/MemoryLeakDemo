using MemoryLeakDemo.ViewModels;

namespace MemoryLeakDemo.Views
{
    public partial class MainPage
    {

        public MainPage(MainPageViewModel viewModel)
        {
            GC.Collect();

            BindingContext = viewModel;

            InitializeComponent();
        }
        private void RefreshStats()
        {
            double heapSize = GC.GetTotalMemory(false)
                              / 1024d;
            HeapSizeLabel.Text = $"Heap Size: {heapSize:n2} KB";
        }
        protected override void OnAppearing()
        {
            RefreshStats();
            base.OnAppearing();

        }
        ~MainPage() 
        { 
        
        }
    }

}
