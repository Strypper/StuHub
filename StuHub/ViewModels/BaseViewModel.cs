using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace StuHub.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public HttpClient httpClient = new HttpClient();

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get  => _isRefreshing; 
            set => OnPropertyChanged(); 
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
