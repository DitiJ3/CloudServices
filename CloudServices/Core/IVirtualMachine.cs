using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    internal interface IVirtualMachine
    {
        void Provision();        // Provision the virtual machine
        void Start();            // Start the virtual machine
        void Stop();             // Stop the virtual machine
        void Reboot();           // Reboot the virtual machine
        string GetDetails();     // Get details about the virtual machine
    }
}
