using CloudServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.AWS
{
    internal class AWSVPC : IVNet
    {
        // Properties for VPC configuration
        public string VnetName { get; set; } = "MyVPC";  // Default VPC name
        public string CIDRBlock { get; set; } = "10.0.0.0/16";  // Default CIDR block for VPC
        public bool IsConfigured { get; set; } = false;  // Tracks if the VPC is configured

        // Method to Create the AWS VPC
        public void Create()
        {
            // create an AWS VPC
            Console.WriteLine($"Creating AWS VPC with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Initially, it's not configured
        }

        // Method to Delete the AWS VPC
        public void Delete()
        {
            // delete the AWS VPC
            Console.WriteLine($"Deleting AWS VPC with CIDR Block {CIDRBlock}...");
            IsConfigured = false;  // Reset configuration status
        }

        // Method to Configure the AWS VPC (e.g., setting CIDR block, subnets)
        public void Configure()
        {
            // Configure the AWS VPC
            Console.WriteLine($"Configuring AWS VPC with CIDR Block {CIDRBlock}...");
            IsConfigured = true;  // Mark as configured
        }

        // Method to Get the Details of the AWS VPC
        public string GetDetails()
        {
            // Retrieve details of the AWS VPC
            return $"AWS VPC Details: {VnetName}, CIDR Block: {CIDRBlock}, Configured: {IsConfigured}";
        }
    }
}