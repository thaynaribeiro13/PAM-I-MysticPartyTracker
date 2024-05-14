using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModel
{
    public partial class DiceViewModel : ObservableObject //partial: parte da classe está em outro arquivo
    {
        public DiceViewModel() 
        {
            RollCommand = new Command(Roll);
        }
        //[ObservableProperty] serve para observar as mudanças(valores) que possam acontecer na classe selecionada.
        [ObservableProperty]
        public int _sides;
        [ObservableProperty]
        public int _quantity;
        [ObservableProperty]
        public int _total;

        private ObservableCollection<int> _rolls = new ObservableCollection<int>();
        public ObservableCollection<int> Rolls
        {
            get { return _rolls; }
            set { _rolls = value;}
        }

        public ICommand RollCommand { get; }

        public void Roll()
        {
            Rolls.Clear();
            _total = 0;
            Dice dice = new Dice(_sides);

            for (int i = 0; i < _quantity; i++)
            {
                int roll = dice.Roll();
                Rolls.Add(roll);
                _total += roll;
            }

        }
    }
}
