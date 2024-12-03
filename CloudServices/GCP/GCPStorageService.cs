using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.GCP
{
    internal class GCPStorageService : IStorageService
    {
        // Property for Storage Type
        public string StorageType { get; set; } = "SSD";  // Default storage type
        public int StorageCapacityGB { get; set; } = 50;  // Default storage capacity in GB
        public bool IsEncrypted { get; set; } = true;  // Default encryption status

        // Method to Provision GCP Storage
        public void Provision()
        {
            // provisione GCP storage
            Console.WriteLine($"Provisioning GCP Storage of type {StorageType} with capacity {StorageCapacityGB} GB...");
        }

        // Method to Attach the GCP Storage to a Virtual Machine
        public void AttachToVM()
        {
            // attache GCP storage to a virtual machine
            Console.WriteLine("Attaching GCP Storage to Virtual Machine...");
        }

        // Method to Detach the GCP Storage from a Virtual Machine
        public void DetachFromVM()
        {
            // detache GCP storage from a virtual machine
            Console.WriteLine("Detaching GCP Storage from Virtual Machine...");
        }

        // Method to Get the Status of the GCP Storage
        public string GetStatus()
        {
            // retrieve the status of GCP storage
            return $"GCP Storage Status: Available (Type: {StorageType}, Capacity: {StorageCapacityGB} GB, Encrypted: {IsEncrypted})";
        }

        // Method to Get the Details of the GCP Storage
        public string GetDetails()
        {
            // retrieve details of the GCP storage
            return $"GCP Storage Details: {StorageType}, {StorageCapacityGB} GB, Encrypted: {IsEncrypted}";
        }
    }
}