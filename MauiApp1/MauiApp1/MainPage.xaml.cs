namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            // interpolação de strings {count}
            if (count == 1)
                CounterBtn.Text = $"Clickou {count} vez";
            else
                CounterBtn.Text = $"Clickou {count} vezes";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnTela2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }

}
