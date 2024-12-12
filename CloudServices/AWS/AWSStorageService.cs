using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    public class AWSStorageService : IStorageService
    {
        // Property for Storage Type
        public string StorageType { get; set; } = "SSD";  // Default storage type
        public int StorageCapacityGB { get; set; } = 50;  // Default storage capacity in GB
        public bool IsEncrypted { get; set; } = true;  // Default encryption status

        // Method to Provision AWS Storage
        public void Provision()
        {
            // provisione AWS storage
            Console.WriteLine($"Provisioning AWS Storage of type {StorageType} with capacity {StorageCapacityGB} GB...");
        }

        // Method to Attach the AWS Storage to a Virtual Machine
        public void AttachToVM()
        {
            // attache AWS storage to a virtual machine
            Console.WriteLine("Attaching AWS Storage to Virtual Machine...");
        }

        // Method to Detach the AWS Storage from a Virtual Machine
        public void DetachFromVM()
        {
            // detache AWS storage from a virtual machine
            Console.WriteLine("Detaching AWS Storage from Virtual Machine...");
        }

        // Method to Get the Status of the AWS Storage
        public string GetStatus()
        {
            // retrieve the status of AWS storage
            return $"AWS Storage Status: Available (Type: {StorageType}, Capacity: {StorageCapacityGB} GB, Encrypted: {IsEncrypted})";
        }

        // Method to Get the Details of the AWS Storage
        public string GetDetails()
        {
            // retrieve details of the AWS storage
            return $"AWS Storage Details: {StorageType}, {StorageCapacityGB} GB, Encrypted: {IsEncrypted}";
        }
    }
}