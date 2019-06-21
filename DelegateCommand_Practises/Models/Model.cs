using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateCommand_Practises.Models
{
    class Model : ObservableObject
    {
        private string connectionStatus;
        public string ConnectionStatus
        {
            get
            {
                return connectionStatus;
            }
            set
            {
                connectionStatus = value;
                OnPropertyChanged("ConnectionStatus");
            }
        }

        public Model()
        {
            connectionStatus = "Connect";
        }

        public async Task Connect()
        {            
            Debug.WriteLine($"{ConnectionStatus}ing...");
            await Task.Run(() => Thread.Sleep(5000));            
            Debug.WriteLine($"{ConnectionStatus}ed!");
            ToggleConnectionStatus();
        }

        public void ToggleConnectionStatus()
        {
            if (ConnectionStatus == "Connect")
                ConnectionStatus = "Disconnect";
            else
                ConnectionStatus = "Connect";
        }
    }
}
