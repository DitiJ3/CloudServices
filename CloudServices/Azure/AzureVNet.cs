using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Azure
{
    public class AzureVnet : IVNet
    {
        // Properties for Vnet configuration
        public string VnetName { get; set; } = "MyVnet";  // Default Vnet name
        public string CIDRBlock { get; set; } = "10.0.0.0/16";  // Default CIDR block for Vnet
        public bool IsConfigured { get; set; } = false;  // Tracks if the Vnet is configured

        // Method to Create the Azure Vnet
        public void Create()
        {
            // create an Azure Vnet
            Console.WriteLine($"Creating Azure Vnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Initially, it's not configured
        }

        // Method to Delete the Azure Vnet
        public void Delete()
        {
            // delete the Azure Vnet
            Console.WriteLine($"Deleting Azure Vnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Reset configuration status
        }

        // Method to Configure the Azure Vnet (e.g., setting CIDR block, subnets)
        public void Configure()
        {
            // Configure the Azure Vnet
            Console.WriteLine($"Configuring Azure Vnet with CIDR Block {CIDRBlock}...");
            IsConfigured = true;  // Mark as configured
        }

        // Method to Get the Details of the Azure Vnet
        public string GetDetails()
        {
            // Retrieve details of the Azure Vnet
            return $"Azure Vnet Details: {VnetName}, CIDR Block: {CIDRBlock}, Configured: {IsConfigured}";
        }
    }
}