using MysticPartyTracker.Model;
namespace MysticPartyTracker.View;
using MysticPartyTracker.ViewModel;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
        BindingContext = new DiceViewModel();
	}

    private void DiceBtn_Clicked(object sender, EventArgs e)
    {
        DiceResult.Text = string.Empty;

        //Pegar quantidade de dados selecionada pelo usuário
        int diceNumber = Convert.ToInt32(DicePicker.SelectedItem);

        //Pegar quantidade de lados dos dados
        int lados = Convert.ToInt32(SidePicker.SelectedItem);

        //Sortear valor de cada lado
        for (int i = 0; i < diceNumber; i++)
        {
            //Resultado de todos os Dados
            DiceResult.Text += Convert.ToString(new Dice(lados).Roll()) + " ";
        }
        //Exibir resultado

    }

    private void DicePicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void SidePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int sideNumber = Convert.ToInt32(SidePicker.SelectedItem);
        Dice dice = new Dice(sideNumber);
        DiceResult.Text = Convert.ToString(dice.Roll());
    }
   
}