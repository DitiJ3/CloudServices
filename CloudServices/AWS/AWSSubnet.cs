using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    public class AWSSubnet : ISubnet
    {
        // Properties for Subnet configuration
        public string SubnetName { get; set; } = "MySubnet";  // Default subnet name
        public string CIDRBlock { get; set; } = "10.0.1.0/24";  // Default CIDR block
        public bool IsConfigured { get; set; } = false;  // Tracks whether the subnet is configured

        // Method to Create the AWS Subnet
        public void Create()
        {
            // create an AWS subnet
            Console.WriteLine($"Creating AWS Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Initially, it's not configured
        }

        // Method to Delete the AWS Subnet
        public void Delete()
        {
            // delete an AWS subnet
            Console.WriteLine($"Deleting AWS Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Reset configuration status
        }

        // Method to Configure the AWS Subnet (e.g., IP range)
        public void Configure()
        {
            // configure the AWS subnet
            Console.WriteLine($"Configuring AWS Subnet with CIDR Block {CIDRBlock}...");
            IsConfigured = true;  // Mark as configured
        }

        // Method to Get the Details of the AWS Subnet
        public string GetDetails()
        {
            // retrieve details of the AWS subnet
            return $"AWS Subnet Details: {SubnetName}, CIDR Block: {CIDRBlock}, Configured: {IsConfigured}";
        }
    }
}