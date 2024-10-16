namespace ActividadGit;

public partial class messi : ContentPage
{
	public messi()
	{
		InitializeComponent();
	}

    private async void atras(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}