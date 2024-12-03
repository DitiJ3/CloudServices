using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Azure
{
    internal class AzureSubnet : ISubnet
    {
        // Properties for Subnet configuration
        public string SubnetName { get; set; } = "MySubnet";  // Default subnet name
        public string CIDRBlock { get; set; } = "10.0.1.0/24";  // Default CIDR block
        public bool IsConfigured { get; set; } = false;  // Tracks whether the subnet is configured

        // Method to Create the Azure Subnet
        public void Create()
        {
            // create an Azure subnet
            Console.WriteLine($"Creating Azure Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Initially, it's not configured
        }

        // Method to Delete the Azure Subnet
        public void Delete()
        {
            // delete an Azure subnet
            Console.WriteLine($"Deleting Azure Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Reset configuration status
        }

        // Method to Configure the Azure Subnet (e.g., IP range)
        public void Configure()
        {
            // configure the Azure subnet
            Console.WriteLine($"Configuring Azure Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = true;  // Mark as configured
        }

        // Method to Get the Details of the Azure Subnet
        public string GetDetails()
        {
            // retrieve details of the Azure subnet
            return $"Azure Subnet Details: {SubnetName}, CIDR Block: {CIDRBlock}, Configured: {IsConfigured}";
        }
    }
}