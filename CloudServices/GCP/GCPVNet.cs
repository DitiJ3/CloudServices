using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.GCP
{
    public class GCPVnet : IVNet
    {
        // Properties for Vnet configuration
        public string VnetName { get; set; } = "MyVnet";  // Default Vnet name
        public string CIDRBlock { get; set; } = "10.0.0.0/16";  // Default CIDR block for Vnet
        public bool IsConfigured { get; set; } = false;  // Tracks if the Vnet is configured

        // Method to Create the GCP Vnet
        public void Create()
        {
            // create an GCP Vnet
            Console.WriteLine($"Creating GCP Vnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Initially, it's not configured
        }

        // Method to Delete the GCP Vnet
        public void Delete()
        {
            // delete the GCP Vnet
            Console.WriteLine($"Deleting GCP Vnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Reset configuration status
        }

        // Method to Configure the GCP Vnet (e.g., setting CIDR block, subnets)
        public void Configure()
        {
            // Configure the GCP Vnet
            Console.WriteLine($"Configuring GCP Vnet with CIDR Block {CIDRBlock}...");
            IsConfigured = true;  // Mark as configured
        }

        // Method to Get the Details of the GCP Vnet
        public string GetDetails()
        {
            // Retrieve details of the GCP Vnet
            return $"GCP Vnet Details: {VnetName}, CIDR Block: {CIDRBlock}, Configured: {IsConfigured}";
        }
    }
}