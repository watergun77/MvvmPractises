using Eduardo.Rosas.ViewModels.Commands;
using System.Diagnostics;

namespace Eduardo.Rosas.ViewModels
{
    public class ViewModelBase
    {
        public SimpleCommand SimpleCommand { get; set; }
        public ParameterCommand ParameterCommand { get; set; }

        public ViewModelBase()
        {
            SimpleCommand = new SimpleCommand(this);
            ParameterCommand = new ParameterCommand(this);
        }
        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }
        public void ParameterMethod(string person)
        {
            Debug.WriteLine(person);
        }
    }
}
