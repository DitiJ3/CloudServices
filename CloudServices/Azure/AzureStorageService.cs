using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Azure
{
    internal class AzureStorageService : IStorageService
    {
        // Property for Storage Type
        public string StorageType { get; set; } = "SSD";  // Default storage type
        public int StorageCapacityGB { get; set; } = 50;  // Default storage capacity in GB
        public bool IsEncrypted { get; set; } = true;  // Default encryption status

        // Method to Provision Azure Storage
        public void Provision()
        {
            // provisione Azure storage
            Console.WriteLine($"Provisioning Azure Storage of type {StorageType} with capacity {StorageCapacityGB} GB...");
        }

        // Method to Attach the Azure Storage to a Virtual Machine
        public void AttachToVM()
        {
            // attache Azure storage to a virtual machine
            Console.WriteLine("Attaching Azure Storage to Virtual Machine...");
        }

        // Method to Detach the Azure Storage from a Virtual Machine
        public void DetachFromVM()
        {
            // detache Azure storage from a virtual machine
            Console.WriteLine("Detaching Azure Storage from Virtual Machine...");
        }

        // Method to Get the Status of the Azure Storage
        public string GetStatus()
        {
            // retrieve the status of Azure storage
            return $"Azure Storage Status: Available (Type: {StorageType}, Capacity: {StorageCapacityGB} GB, Encrypted: {IsEncrypted})";
        }

        // Method to Get the Details of the Azure Storage
        public string GetDetails()
        {
            // retrieve details of the Azure storage
            return $"Azure Storage Details: {StorageType}, {StorageCapacityGB} GB, Encrypted: {IsEncrypted}";
        }
    }
}