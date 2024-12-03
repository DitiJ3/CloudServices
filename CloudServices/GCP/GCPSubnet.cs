using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.GCP
{
    internal class GCPSubnet : ISubnet
    {
        // Properties for Subnet configuration
        public string SubnetName { get; set; } = "MySubnet";  // Default subnet name
        public string CIDRBlock { get; set; } = "10.0.1.0/24";  // Default CIDR block
        public bool IsConfigured { get; set; } = false;  // Tracks whether the subnet is configured

        // Method to Create the GCP Subnet
        public void Create()
        {
            // create an GCP subnet
            Console.WriteLine($"Creating GCP Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Initially, it's not configured
        }

        // Method to Delete the GCP Subnet
        public void Delete()
        {
            // delete an GCP subnet
            Console.WriteLine($"Deleting GCP Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Reset configuration status
        }

        // Method to Configure the GCP Subnet (e.g., IP range)
        public void Configure()
        {
            // configure the GCP subnet
            Console.WriteLine($"Configuring GCP Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = true;  // Mark as configured
        }

        // Method to Get the Details of the GCP Subnet
        public string GetDetails()
        {
            // retrieve details of the GCP subnet
            return $"GCP Subnet Details: {SubnetName}, CIDR Block: {CIDRBlock}, Configured: {IsConfigured}";
        }
    }
}