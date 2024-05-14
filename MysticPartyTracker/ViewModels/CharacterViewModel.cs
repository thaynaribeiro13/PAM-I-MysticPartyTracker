
using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModel : ObservableObject
    {
        public CharacterViewModel() 
        {
            CriarCommand = new Command(Criar);
        }

        [ObservableProperty]
        private string _nomePersonagem;
        [ObservableProperty]
        private string _classePersonagem;
        [ObservableProperty]
        private string _racaPersonagem;
        [ObservableProperty]
        private int _nivelPersonagem;
   

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        { 
            get { return _characters; } 
            set { _characters = value; } 
        }

        public ICommand CriarCommand { get;}

        public void Criar()
        {
            Character character = new Character(NomePersonagem, ClassePersonagem, RacaPersonagem, NivelPersonagem);
            Characters.Add(character);
        }
    }
}
