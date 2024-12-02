using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    internal class AWSVirtualMachine : IVirtualMachine
    {
        public void Provision()
        {
            // Simulate provisioning an AWS virtual machine
            Console.WriteLine("Provisioning AWS Virtual Machine...");
        }

        public void Start()
        {
            // Simulate starting the AWS virtual machine
            Console.WriteLine("Starting AWS Virtual Machine...");
        }

        public void Stop()
        {
            // Simulate stopping the AWS virtual machine
            Console.WriteLine("Stopping AWS Virtual Machine...");
        }

        public void Reboot()
        {
            // Simulate rebooting the AWS virtual machine
            Console.WriteLine("Rebooting AWS Virtual Machine...");
        }

        public string GetDetails()
        {
            // Simulate retrieving details of the AWS virtual machine
            return "AWS Virtual Machine Details: t2.micro, 2GB RAM, 1vCPU";
        }

    }
}
