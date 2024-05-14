using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.View;

public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
		InitializeComponent();
		BindingContext = new CharacterViewModel();
	}
}