using Microsoft.Maui.Controls.Platform;

namespace ControleDAMRaouf;

public partial class Hello : ContentPage
{
	public Hello()
	{
		InitializeComponent();
	}

    public int nbConnexionsReussies = 0;
    
	private void Button_Clicked(object sender, EventArgs e)
	{
        var motDePasseSaisi = passEntry.Text;
        if (passEntry.Text == "DAM2024")
		{
           nbConnexionsReussies++;
           this.Navigation.PushAsync(new Bravo(nbConnexionsReussies));           
		}
		else
		{
            DisplayAlert("Erreur", "Mot de passe incorrect.", "OK");
        }
		

    }
}