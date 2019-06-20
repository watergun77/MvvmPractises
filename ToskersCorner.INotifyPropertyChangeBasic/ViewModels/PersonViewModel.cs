using ToskersCorner.INotifyPropertyChangeBasic.Models;

namespace ToskersCorner.INotifyPropertyChangeBasic.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; private set; }
        public PersonViewModel()
        {
            Person = new Person();
        }
    }
}
