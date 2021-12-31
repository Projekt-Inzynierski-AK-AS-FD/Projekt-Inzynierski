using PropertyChanged;
using System.ComponentModel;
namespace Abituria.viewmodel
{
    [ImplementPropertyChanged]
    public class BaseViewModel : INotifyPropertyChanged///Bazowy model widoku odpala Property Changed kiedy trzeba
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) =>
        {
            if (sender is null)
            {
                throw new System.ArgumentNullException(nameof(sender));
            }
            if (e is null)
            {
                throw new System.ArgumentNullException(nameof(e));
            }
        };///Wydarzenie odpala się, kiedy właściwość potomka się zmienia
        public void OnPropertyChanged(string name)///Wywołuje wydarzenie PropertyChanged
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}