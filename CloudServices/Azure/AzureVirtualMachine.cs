using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Azure
{
    public class AzureVirtualMachine : IVirtualMachine
    {
        // Properties with default values
        public string VMSize { get; set; } = "ev5";  // Default size
        public string Region { get; set; } = "us-east-a";  // Default region
        public bool IsRunning { get; set; } = false;  // Tracks whether the VM is running

        // Provision, start, stop, reboot, and get details methods
        public void Provision()
        {
            Console.WriteLine($"Provisioning Azure Virtual Machine of size {VMSize} in region {Region}...");
            IsRunning = false;
        }

        public void Start()
        {
            Console.WriteLine($"Starting Azure Virtual Machine of size {VMSize} in region {Region}...");
            IsRunning = true;
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping Azure Virtual Machine of size {VMSize} in region {Region}...");
            IsRunning = false;
        }

        public void Reboot()
        {
            Console.WriteLine($"Rebooting Azure Virtual Machine of size {VMSize} in region {Region}...");
        }

        public string GetDetails()
        {
            return $"Azure Virtual Machine Details: {VMSize}, {Region}, Is Running: {IsRunning}";
        }
    }
}