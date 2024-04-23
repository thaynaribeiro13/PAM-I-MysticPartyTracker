using MysticPartyTracker.Model;
namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		DicePicker.SelectedIndex = 0;
        SidePicker.SelectedIndex = 0;
	}

    private void DiceBtn_Clicked(object sender, EventArgs e)
    {
        int diceNumber = Convert.ToInt32(DicePicker.SelectedItem);
        Dice dice = new Dice(diceNumber);
        DiceResult.Text = Convert.ToString(dice.Roll());
    }

    private void SidePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int sideNumber = Convert.ToInt32(SidePicker.SelectedItem);
        Dice dice = new Dice(sideNumber);
        DiceResult.Text = Convert.ToString(dice.Roll());
    }
}