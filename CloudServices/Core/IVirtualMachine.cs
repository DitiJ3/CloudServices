using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    public interface IVirtualMachine
    {
        void Provision();        // Provision the virtual machine
        void Start();            // Start the virtual machine
        void Stop();             // Stop the virtual machine
        void Reboot();           // Reboot the virtual machine
        string GetDetails();     // Get details about the virtual machine
        string VMSize { get; set; } // Get and Set specific size for the virtual machine
        string Region { get; set; } // Get  and Set specific region for the virtual machine

    }
}
