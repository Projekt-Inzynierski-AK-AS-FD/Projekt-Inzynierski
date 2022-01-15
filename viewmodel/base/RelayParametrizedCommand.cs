using System;
using System.Windows.Input;
using PropertyChanged;
namespace Abituria.viewmodel
{
    class RelayParametrizedCommand : ICommand///Podstawowa komenda odpalacjąca Akcje
    {
        private readonly Action<object> mAction;///Akcja do odpalenia
        private Func<object, bool> mCanExecute;
        public event EventHandler CanExecuteChanged = (sender, e) => { };///Wydarzenie odpalane, kiedy wartość obiektu jest zmieniona
        public RelayParametrizedCommand(Action<object> action)///Standardowy konstruktor
        {
            mAction = action;
        }
        public bool CanExecute(object parameter) => true;/// Polecenie przekaźnika zawsze może zostać wykonane
        public void Execute(object parameter) => mAction(parameter);/// Wykonuje komende Akcja
    }
}