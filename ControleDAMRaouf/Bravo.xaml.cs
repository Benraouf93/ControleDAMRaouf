namespace ControleDAMRaouf;

public partial class Bravo : ContentPage
{
    private int nbConnexionsReussies;
    public Bravo(int nbConnexionsReussies)
	{
        
        this.nbConnexionsReussies = nbConnexionsReussies;

        InitializeComponent();

        nbConnexionsLabel.Text = nbConnexionsReussies.ToString();
    }
}