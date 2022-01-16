using System;
using System.Windows.Input;
using PropertyChanged;
namespace Abituria.viewmodel
{
    class RelayCommand : ICommand///Podstawowa komenda odpalacjąca Akcje
    {
        private readonly Action mAction;///Akcja do odpalenia
        private Func<object, bool> mCanExecute;
        public event EventHandler CanExecuteChanged = (sender, e) => { };///Wydarzenie odpalane, kiedy wartość obiektu jest zmieniona
        public RelayCommand(Action action)///Standardowy konstruktor
        {
            mAction = action;
        }
        public bool CanExecute(object parameter) => true;/// Polecenie przekaźnika zawsze może zostać wykonane
        public void Execute(object parameter) => mAction();/// Wykonuje komende Akcja
    }
}