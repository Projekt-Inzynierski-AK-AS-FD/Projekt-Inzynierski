using PropertyChanged;
using System;
using System.ComponentModel;
using System.Linq.Expressions; 
using System.Threading.Tasks;
namespace Abituria.viewmodel
{
    public class WindowViewModel : INotifyPropertyChanged///Bazowy model widoku odpala Property Changed kiedy trzeba
    {
        protected object mPropertyValueCheckLock = new object();///Globalna blokada wyrażeń instancji
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };///Wydarzenie odpala się, kiedy właściwość potomka się zmienia
        protected void OnPropertyChanged(string name) => PropertyChanged(this, new PropertyChangedEventArgs(name));///Wywołuje wydarzenie PropertyChanged
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)///Odpala komende jeżeli flaga aktualizowania nie jest ustawiona
        {
            if (updatingFlag.GetPropertyValue())//.Compile().Invoke())
                return;
            updatingFlag.SetPropertyValue(true);
            try
            {
                await action();///Odpala akcje
            }
            finally
            {
                updatingFlag.SetPropertyValue(false);///Ustawia właściwość flagi na fałsz po skończeniu
            }
        }
    }
}