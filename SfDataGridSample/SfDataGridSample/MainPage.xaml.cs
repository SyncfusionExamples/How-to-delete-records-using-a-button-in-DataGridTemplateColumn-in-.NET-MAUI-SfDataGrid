namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is not Button btn)
                return;

            var parameter = btn.CommandParameter;

            bool confirm = await DisplayAlert("Confirm Delete", "Are you sure you want to delete this record?", "Delete", "Cancel");
            if (!confirm)
                return;

                viewModel?.DeleteRecord?.Execute(parameter);
        }
    }
}
