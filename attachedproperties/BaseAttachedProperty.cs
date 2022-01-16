using System;
using System.Windows;
namespace Abituria
{
    public abstract class BaseAttachedProperty<Parent, Property> where Parent : BaseAttachedProperty<Parent, Property>, new()///Bazowa właściwość dołączona
    {
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e)=>{};///Odpalane, gdy wartość ulega zmianie
        public static Parent Instance { get; private set; } = new Parent();///Pojedyńcza instancja klasy Parent
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(Property), typeof(BaseAttachedProperty<Parent, Property>), new PropertyMetadata(new PropertyChangedCallback(OnValuePropertyChanged)));///Właściwość dołączona dla tej klasy
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)///Wydarzenie wywoływane, kiedy ValueProperty jest zmieniane. Działa jak konstruktor
        {
            Instance.OnValueChanged(d, e);///Wywołaj funkcje rodzica
            Instance.ValueChanged(d, e);///Wywołaj nasłuchujących wwydarzenie
        }
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);///Bierze właściwość dołączoną
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);///Ustawia właściwość dołączoną
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }///Metoda wywoływana, gdy jakakolwiek właściwość dołączona tego typu jest zmieniona
    }
}