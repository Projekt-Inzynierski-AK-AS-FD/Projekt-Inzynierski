using PropertyChanged;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Abituria.viewmodel
{
    [ImplementPropertyChanged]
    public class BaseViewModel : INotifyPropertyChanged///Bazowy model widoku odpala Property Changed kiedy trzeba
    {
        protected object mPropertyValueCheckLock = new object();///Globalna blokada wyrażeń instancji
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };///Wydarzenie odpala się, kiedy właściwość potomka się zmienia
        protected void OnPropertyChanged(string name)///Wywołuje wydarzenie PropertyChanged
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}