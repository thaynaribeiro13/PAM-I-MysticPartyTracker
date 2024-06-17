using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MysticPartyTracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using MysticPartyTracker.Views;

namespace MysticPartyTracker.ViewModels
{
    public partial class ResultViewModel : ObservableObject
    {
        private readonly RestService _restService;
        public ResultViewModel()
        {
            _restService = new RestService();
            FindMagicAsyncCommand = new Command(async () => await GetResultsAsync());
        }

        [ObservableProperty]
        private string _index;

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private int _level;

        [ObservableProperty]
        private string _url;

        private ObservableCollection<Result> _results = new ObservableCollection<Result>();
        public ObservableCollection<Result> Results
        {
            get { return _results; }
            set { _results = value; }
        }

        public ICommand FindMagicAsyncCommand { get; }

        public async Task<ObservableCollection<Result>> GetResultsAsync()
        {
            return await _restService.GetResultsAsync();
        }
    }
}
