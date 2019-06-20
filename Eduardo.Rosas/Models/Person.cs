using System.ComponentModel;

namespace Eduardo.Rosas.Models
{
    class Person : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("FullName");
            }
        }
        private string lastname;
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }
        private string fullname;
        public string FullName
        {
            get { return $"{name} {lastname}"; }
            set
            {
                fullname = value;
                OnPropertyChanged("FullName");
            }
        }

        public Person()
        {
            Name = "Eduardo";
            LastName = "Rosas";            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
