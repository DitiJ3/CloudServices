using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    internal class AWSStorageService : IStorageService
    {
        public void Provision()
        {
            // Simulate provisioning AWS storage
            Console.WriteLine("Provisioning AWS Storage...");
        }

        public void AttachToVM()
        {
            // Simulate attaching AWS storage to a virtual machine
            Console.WriteLine("Attaching AWS Storage to Virtual Machine...");
        }

        public void DetachFromVM()
        {
            // Simulate detaching AWS storage from a virtual machine
            Console.WriteLine("Detaching AWS Storage from Virtual Machine...");
        }

        public string GetStatus()
        {
            // Simulate retrieving the status of AWS storage
            return "AWS Storage Status: Available";
        }

        public string GetDetails()
        {
            // Simulate retrieving details of the AWS storage
            return "AWS Storage Details: 50GB SSD";
        }
    }
}
