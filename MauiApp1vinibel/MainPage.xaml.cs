 namespace MauiApp1vinibel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name;

    // construtor metodo
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnMessageClicked(object sender, EventArgs e)
        { 
        name = NameEntry.Text;
        MessageLabel.Text = $"Hello, {name}!";
        }
    }

}
