namespace ToskersCorner.INotifyPropertyChangeBasic.Models
{
    public class Person : ObservableObject
    {
        private string _name;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    return "Unknown";

                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
