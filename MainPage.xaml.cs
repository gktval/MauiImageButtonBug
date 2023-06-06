
namespace MauiAppImageButton;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        SemanticScreenReader.Announce(CounterBtn.Text);
        if (imgBtn.BorderColor == Colors.Red)
        {
            imgBtn.BorderColor = Colors.Green;
        }
        else
        {
            imgBtn.BorderColor = Colors.Red;
        }

        CounterBtn.Text = $"Button border color is {imgBtn.BorderColor}";
    }
}

