using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    public interface IVNet
    {
        void Create();              // Create a virtual network
        void Delete();              // Delete the virtual network
        void Configure();           // Configure the VNet
        string GetDetails();        // Get details about the VNet
        string VnetName { get; set; } // Name of the VNet
        string CIDRBlock { get; set; } // Classless Inter-Domain Routing Block
        Boolean IsConfigured { get; set; } // Check if the VNet is configured
    }
}
