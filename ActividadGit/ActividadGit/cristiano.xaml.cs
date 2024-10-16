namespace ActividadGit;

public partial class cristiano : ContentPage
{
	public cristiano()
	{
		InitializeComponent();
	}

    private async void atras1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}