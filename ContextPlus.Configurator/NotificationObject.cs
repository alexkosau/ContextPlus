using System.ComponentModel;

namespace ContextPlus.Configurator
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public void ChangeAndNotify<T>(ref T accessor, T value, string propertyName)
            where T: class
        {
            if (accessor != value)
            {
                accessor = value;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        public event PropertyChangedEventHandler PropertyChanged = delegate {};
    }
}