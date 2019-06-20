using DCOMProductions.MvvmDemo.Models;
using System.Diagnostics;

namespace DCOMProductions.MvvmDemo.ViewModels
{
    public class CustomerViewModel
    {
        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// </summary>
        public CustomerViewModel()
        {
            customer = new Customer("David");
        }        
        public Customer customer { get; }
       
        public void SaveChanges()
        {
            Debug.Assert(false, $"{customer.Name} was updated.");
        }

    }
}
