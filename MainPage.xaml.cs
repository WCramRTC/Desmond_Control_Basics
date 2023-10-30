namespace Desmond_Control_Basics
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnDisplayName_Clicked(object sender, EventArgs e)
        {
            string name = entName.Text;
            await DisplayAlert("Your Name", name, "Nice to meet you!");
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        //private async void btnSecondPage_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Alert", "You have been alerted", "OK");
        //}
    }
}