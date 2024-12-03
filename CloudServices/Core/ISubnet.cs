using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    internal interface ISubnet
    {
        void Create();              // Create a subnet
        void Delete();              // Delete the subnet
        void Configure();           // Configure subnet settings 
        string GetDetails();        // Get details about the subnet
        public string SubnetName { get; set; } // Name of the subnet
        public string CIDRBlock { get; set; } // Classless Inter-Domain Routing Block
        public Boolean IsConfigured { get; set; } // Check if the subnet is configured
    }
}
