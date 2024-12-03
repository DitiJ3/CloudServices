using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServices.Core
{
    internal interface IVNet
    {
        void Create();              // Create a virtual network
        void Delete();              // Delete the virtual network
        void Configure();           // Configure the VNet
        string GetDetails();        // Get details about the VNet
        string VnetName { get; set; }
        string CIDRBlock { get; set; }
        Boolean IsConfigured { get; set; }
    }
}
